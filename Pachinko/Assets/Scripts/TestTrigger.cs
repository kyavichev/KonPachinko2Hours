using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    public GameObject playerBallPrefab;
    public GameObject spawnPoint;


    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        // Check of collider object has a player reference
        PlayerReference colliderPlayerReference = collider.gameObject.GetComponent<PlayerReference>();
        if(colliderPlayerReference == null)
        {
            // if not, return early
            return;
        }

        // Create a new instance of a PlayerBall prefab
        GameObject newPlayerBallInstance = Instantiate(playerBallPrefab);
        Vector3 position = spawnPoint.transform.position;
        newPlayerBallInstance.transform.position = position;

        PlayerReference playerReference = newPlayerBallInstance.GetComponent<PlayerReference>();
        playerReference.player = colliderPlayerReference.player;
    }
}
