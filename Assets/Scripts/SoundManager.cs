using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioClip> sounds;
    public AudioSource audioSource;
    public void PlayRandomSound()
    {
        int randomSound = Random.Range(0, sounds.Count);
        audioSource.PlayOneShot(sounds[randomSound]);
    }
}
