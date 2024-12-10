using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnUpdate : MonoBehaviour
{
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }
}
