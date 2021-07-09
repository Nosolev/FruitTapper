using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : ObjectSettings
{
	public int hitPoints = 1;
	public int scorePrice = 1;

	void Update()
	{
		if (transform.localPosition.y <= GetCameraSize.botOfCamera)
		{
			DeathTimer.ReduceTime();
			Destroy(gameObject);
		}
	}

	public override void OnMouseDown()
	{
		base.OnMouseDown();
		hitPoints -= 1;
		if (hitPoints <= 0)
		{
			ScoreCounter.AddScore(scorePrice);
			DeathTimer.AddTime();
			Destroy(gameObject);
		}
	}
}
