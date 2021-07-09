using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public static Text scoreUI;

    void Start()
    {
        scoreUI = GetComponent<Text>();
    }

    static public void UpdateScore()
    {
        scoreUI.text = ScoreCounter.score.ToString();
    }
}
