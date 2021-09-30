using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource sound;

    public float musicVolume = 1f;
    void Start()
    {
        sound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        sound.volume = musicVolume;
    }

    public void volumeChange (float volume)
    {
        musicVolume = volume;

    }
}
