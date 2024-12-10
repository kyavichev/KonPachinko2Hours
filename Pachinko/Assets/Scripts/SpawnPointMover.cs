using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointMover : MonoBehaviour
{
    public float maxRange = 2f;
    public float speed = 0.1f;

    private float direction = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if(position.x > maxRange)
        {
            direction = -1;
        }

        if(position.x < maxRange * -1f)
        {
            direction = 1;
        }

        position.x = position.x + speed * direction;
        transform.position = position;
    }
}
