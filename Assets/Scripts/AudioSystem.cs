using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    static AudioSource source;


    void Awake()
    {
        source = GetComponent<AudioSource>();
    }



    void Update()
    {
        
    }

   

    public static void Play(AudioClip clip, float volume = 1f)
    {
        source.PlayOneShot(clip,volume);
    }
}