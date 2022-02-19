using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTog : MonoBehaviour
{
    AudioSource audioOn;


    void Start()
    {
        audioOn = GetComponent<AudioSource>();    
    }

    public void AudioON()
    {
        audioOn.Play();
    }
}
