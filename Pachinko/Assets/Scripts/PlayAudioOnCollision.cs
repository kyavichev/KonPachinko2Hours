using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{
    public AudioSource audioSource;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();
    }
}
