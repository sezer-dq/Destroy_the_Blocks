using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    static MusicController SingleMusicPlayer = null;

    
    private void Awake()
    {
        //m�zik objesinin tekrar tekrar olu�mas�n� engelliyor

        if (SingleMusicPlayer != null)
        {
            Debug.Log(GetInstanceID());
            Destroy(gameObject);
        }
        else
        {
            SingleMusicPlayer= this;
            DontDestroyOnLoad(gameObject);
            //GameObject.DontDestroyOnLoad(this);
        }
    }
    void Start()
    {   
       
    }
    public void MusicOff()
    {
        SingleMusicPlayer.GetComponent<AudioSource>().mute=true;
        
        //SingleMusicPlayer.GetComponent<AudioSource>().enabled = false;
    }
}
