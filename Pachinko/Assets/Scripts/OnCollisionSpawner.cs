using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnCollisionSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject newObject = Instantiate(prefabToSpawn);
        newObject.transform.position = transform.position;
    }
}
