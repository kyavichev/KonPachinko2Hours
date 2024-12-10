using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomAudioOnCollision : MonoBehaviour
{
    public AudioRandomizer audioRandomizer;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioRandomizer.PlayRandomSound();
    }
}
