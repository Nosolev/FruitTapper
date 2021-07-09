using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
	public static int score = 0;
	public static int scoreRatio = 1; 

	void Start()
	{
		DropScore();
	}

	void DropScore()
	{
		score = 0;
		scoreRatio = 1;
	}

	public static void AddScore(int scoreCount)
	{
		score += scoreCount * scoreRatio;
		UIScore.UpdateScore();
	}
}
