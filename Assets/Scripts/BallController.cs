using System;
using System.Collections;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameBarController gameBar;
    private bool isStarted;
    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = this.transform.position-gameBar.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStarted) 
        {
            this.transform.position = gameBar.transform.position + distance;
            if (Input.GetMouseButtonDown(0))
            {
                isStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 8f);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        //ilerde kýrýlamayan zemin ile buga girmesin diye kullanýlabilir

        if (Mathf.Approximately(gameObject.GetComponent<Rigidbody2D>().velocity.y, 0f))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, -0.3f);
        }
    }
}
