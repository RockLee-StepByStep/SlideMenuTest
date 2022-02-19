using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioON : MonoBehaviour
{
    AudioSource audioOn;
     public AudioClip piu;

    void Start()
    {
        audioOn = GetComponent<AudioSource>();
    }

    public void GoAudio()
    {
        audioOn.Play();
    }
    
    public void ReburnMenu()
    {
        audioOn.PlayOneShot(piu,1);
    }
  
}
