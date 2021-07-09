using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiCoin : MonoBehaviour
{
    public static Text coinUI;

    void Start()
    {
        coinUI = GetComponent<Text>();
    }

    public static void UpdateCoin()
    {
        coinUI.text = CoinCounter.coin.ToString();
    }
}
