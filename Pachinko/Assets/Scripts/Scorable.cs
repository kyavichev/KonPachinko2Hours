using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorable : MonoBehaviour
{
    public int scoreValue = 10;

    public FlyingText flyingTextPrefab;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerReference playerReference = collision.collider.gameObject.GetComponent<PlayerReference>();
        if (playerReference)
        {
            playerReference.player.AddScore(scoreValue);

            if(flyingTextPrefab)
            {
                FlyingText newFlyingText = Instantiate<FlyingText>(flyingTextPrefab);
                newFlyingText.transform.position = transform.position;
                newFlyingText.SetText("+" + scoreValue);
            }
        }
    }
}
