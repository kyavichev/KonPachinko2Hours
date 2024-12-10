using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlyingText : MonoBehaviour
{
    public TextMesh text;

    public float totalDistance = 10;
    public float duration = 3;
    public float fadeStartPercentage = 0.7f;

    private Vector3 startingPosition;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < duration)
        {
            float t = timer / duration;
            float y = t * totalDistance;
            Vector3 newPosition = startingPosition;
            newPosition.y += y;
            transform.position = newPosition;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void SetText(string message)
    {
        text.text = message;
    }
}
