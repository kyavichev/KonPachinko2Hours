using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketWInConditionChecker : MonoBehaviour
{
    public Basket[] baskets;
    public Player player;

    private bool isWon = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isWon == false)
        {
            int winCount = baskets.Length;
            int currentCount = 0;

            for (int i = 0; i < baskets.Length; i++)
            {
                Basket basket = baskets[i];
                if (basket.isFull)
                {
                    currentCount++; // currentCount = currentCount + 1;
                }
            }

            if (winCount == currentCount)
            {
                isWon = true;
                player.Win();
            }
        }
    }
}
