using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRepeller : MonoBehaviour
{
    public float strength = 30f;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 otherPosition = collision.collider.gameObject.transform.position;
        Vector3 myPosition = gameObject.transform.position;

        Vector3 direction = (otherPosition - myPosition).normalized;
        Vector3 force = direction * strength;

        Rigidbody2D rigidbody = collision.collider.gameObject.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(force);
    }
}
