using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseController : MonoBehaviour
{
    public SahneKontrolu manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        manager= GameObject.FindAnyObjectByType<SahneKontrolu>();
        manager.SahneyeYonlen("Kaybetme"); 
    }
}
