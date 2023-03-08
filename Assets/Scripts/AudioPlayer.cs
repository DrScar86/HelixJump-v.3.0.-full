using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource _audio;
    public AudioClip AudioClip;
    [Min(0)]
    public float Volume;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sector")
        {
            _audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Platform")
        {
            _audio.PlayOneShot(AudioClip, Volume);
        }
    }
}
