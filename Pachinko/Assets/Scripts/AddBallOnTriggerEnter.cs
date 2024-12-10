using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBallOnTriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerReference playerReference = collision.gameObject.GetComponent<PlayerReference>();
        if(playerReference)
        {
            playerReference.player.AddBall();
        }
    }
}
