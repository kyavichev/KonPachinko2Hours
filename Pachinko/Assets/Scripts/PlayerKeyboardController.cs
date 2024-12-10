using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboardController : MonoBehaviour
{
    public Player player;
    public GameObject spawnPoint;
    public GameObject playerBallPrefab;

    private float holdDuration = 0;
    public float maxHoldDuration = 3;

    public float forceModifier = 10;

    public GameObject parentObjectForSpawns;


    // Update is called once per frame
    void Update()
    {
        if(player.isWon || player.isFailed)
        {
            return;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            holdDuration = 0;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            holdDuration = holdDuration + Time.deltaTime;
            holdDuration = Mathf.Min(holdDuration, maxHoldDuration);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("holdDuration: " + holdDuration);
            SpawnNewBall();
        }
    }


    private void SpawnNewBall()
    {
        if (player.CanGetNewBall())
        {
            // Create a new instance of a PlayerBall prefab
            GameObject newPlayerBallInstance = Instantiate(playerBallPrefab);
            newPlayerBallInstance.transform.SetParent(parentObjectForSpawns.transform);
            Vector3 position = spawnPoint.transform.position;
            newPlayerBallInstance.transform.position = position;

            PlayerReference playerReference = newPlayerBallInstance.GetComponent<PlayerReference>();
            playerReference.player = player;

            Rigidbody2D rigidbody = newPlayerBallInstance.GetComponent<Rigidbody2D>();
            float xDir = 0; //Random.Range(-100f, 100f);
            rigidbody.AddForce(new Vector2(xDir, -forceModifier * holdDuration));
        }
    }
}
