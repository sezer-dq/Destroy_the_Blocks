using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.touchCount > 0)
        //{
        //    Touch finger = Input.GetTouch(0);
        //    if(finger.phase == TouchPhase.Stationary) 
        //    {
        Vector3 GameBarLocation = new Vector3(0f, this.transform.position.y, 0f);
        float mousePositionX=Input.mousePosition.x/Screen.width*16;
       // float mousePositionX = finger.position.x/ Screen.width * 16;
        GameBarLocation.x = Mathf.Clamp(mousePositionX,1f,15f);
        this.transform.position = GameBarLocation;
     //       }
    //    }
    }
}
