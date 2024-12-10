using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public float radius = 10;
    public float pullStrength = 10;

    public float duration = 3; // seconds
    private float timer = 0;

    public bool polarity = false;

    public SpriteRenderer spriteRenderer;


    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if(timer > duration)
        {
            polarity = !polarity;
            timer = 0;
        }

        if(polarity)
        {
            if (spriteRenderer != null)
            {
                spriteRenderer.color = Color.green;
            }
        }
        else
        {
            if (spriteRenderer != null)
            {
                spriteRenderer.color = Color.red;
            }
        }

        bool repell = false;


        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Pushing A");
            repell = true;
        }

        GameObject playerBallParent = GameObject.Find("PlayerBalls");
        Rigidbody2D[] rigidbodies = playerBallParent.GetComponentsInChildren<Rigidbody2D>();
        for(int i = 0; i < rigidbodies.Length; i++)
        {
            Rigidbody2D rigidbody = rigidbodies[i];

            float distance = Vector3.Distance(transform.position, rigidbody.transform.position);
            if(distance > radius)
            {
                continue;
            }

            Vector3 dir = transform.position - rigidbody.transform.position;
            dir = dir.normalized;

            // per ball
            float strength = 1f - distance / radius;

            //if (repell)
            //{
            //    dir *= -1f;
            //    strength *= 10f;
            //}

            if(polarity == false)
            {
                dir *= -1f;
            }

            rigidbody.AddForce(dir * strength * pullStrength);
        }
    }
}
