using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedScaler : MonoBehaviour
{
    public float duration = 3;
    public float minScale = 0;
    public float maxScale = 1;

    private float timer = 0;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer < duration)
        {
            float t = timer / duration;
            float scale = Mathf.Lerp(maxScale, minScale, t);
            transform.localScale = Vector3.one * scale;
        }
    }
}
