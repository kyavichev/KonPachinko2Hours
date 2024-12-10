using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRandomizer : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] audioClips;


    public void PlayRandomSound()
    {
        int numberOfClips = audioClips.Length;
        int index = Random.Range(0, numberOfClips);
        AudioClip clip = audioClips[index];

        audioSource.clip = clip;
        audioSource.Play();
    }
}
