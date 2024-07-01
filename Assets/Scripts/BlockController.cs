using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private int hitcount;
    private SahneKontrolu scenemanager;
    public Sprite[] blockview;
    public GameObject efect;
    public static int blockcount=0;
    void Start()
    {
        blockcount++;
        hitcount = 0;
        scenemanager= GameObject.FindObjectOfType<SahneKontrolu>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        HitController();
    }
    public void HitController()
    {
        int healt = blockview.Length+1;
        hitcount++;
        if (hitcount >= healt)
        {
            blockcount--;
            CreateEffect(); 
            Destroy(gameObject);
            scenemanager.BlokBitti();
        }
        else
        {
            ChangeBlockView();
        }
    }
    void CreateEffect()
    {
        GameObject myeffect = Instantiate(efect, gameObject.transform.position, Quaternion.identity) as GameObject;
        myeffect.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
    }
    public void ChangeBlockView()
    {
        this.GetComponent<SpriteRenderer>().sprite= blockview[hitcount-1];
    }
    public void NextScene()
    {
        scenemanager.NextScene();
    }
}
