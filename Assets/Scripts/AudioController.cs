using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    public AudioSource Music;
    public AudioSource Music2;
    
    public AudioSource Effect1;

    void Start()
    {
       
    }


    public void music1()
    {
        Effect1.Play();
        Music2.Stop();
        Music.Play();
    }

    public void music2()
    {
        Effect1.Play();
        Music.Stop();
        Music2.Play();
    }


    public void stopallmusic()
    {
        Effect1.Play();
        Music.Stop();
        Music2.Stop();
        
    }
}

  
