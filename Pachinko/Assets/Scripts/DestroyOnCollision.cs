using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject gameObjectToDestroy = collision.collider.gameObject;
        Destroy(gameObjectToDestroy);
    }
}
