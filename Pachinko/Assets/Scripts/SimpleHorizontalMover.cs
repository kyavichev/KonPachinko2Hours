using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleHorizontalMover : MonoBehaviour
{
    public float maxRange = 2f;
    public float speed = 0.1f;

    private float direction = 1f;
    private float startX = 0;


    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;

        // Randomize starting direction
        if (Random.value > 0.5f)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (position.x > startX + maxRange)
        {
            direction = -1;
        }

        if (position.x < startX - maxRange)
        {
            direction = 1;
        }

        position.x = position.x + speed * direction * Time.deltaTime;
        transform.position = position;
    }
}
