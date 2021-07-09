using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public static int coin = 0;
    public static int coinRatio = 1;

    void Start()
    {
        coin = 0;
        coinRatio = 1;
    }

    void Update()
    {
        
    }

    public static void AddCoin()
	{
        coin += coinRatio;
        UiCoin.UpdateCoin();
	}
}
