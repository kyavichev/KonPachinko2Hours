using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    public Basket basket;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("LevelGeometry"))
        {
            return;
        }

        basket.isFull = true;
    }
}
