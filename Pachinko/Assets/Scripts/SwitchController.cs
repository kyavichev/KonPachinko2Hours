using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public GameObject lever;

    public bool isOn = true;
    public bool isAnimating = false;

    public float animationDuration = 1;
    private float animationTimer = 0;

    public KeyCode keyCode;


    // Update is called once per frame
    void Update()
    {
        if (!isAnimating)
        {
            if (Input.GetKeyDown(keyCode))
            {
                isOn = !isOn;
                isAnimating = true;
                animationTimer = 0;
            }
        }

        if(isAnimating)
        {
            RotateLever();
        }
    }


    void RotateLever()
    {
        animationTimer += Time.deltaTime;
        if (animationTimer >= animationDuration)
        {
            isAnimating = false;
            animationTimer = animationDuration;
        }

        // x, y, z
        // on: (0, 0, 0)
        // off: (0, 0, 90)

        Vector3 horRotation = new Vector3(0, 0, 0);
        Vector3 upRotation = new Vector3(0, 0, 90);

        Vector3 targetRotation;
        Vector3 startingRotation;
        if (isOn != true)
        {
            startingRotation = horRotation;
            targetRotation = upRotation;
        }
        else
        {
            startingRotation = upRotation;
            targetRotation = horRotation;
        }

        float t = animationTimer / animationDuration;
        Vector3 currentRotation = Vector3.Lerp(startingRotation, targetRotation, t);

        lever.transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
