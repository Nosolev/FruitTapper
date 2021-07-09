using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : ObjectSettings
{
	public override void OnMouseDown()
	{
		base.OnMouseDown();
		CoinCounter.AddCoin();
		Destroy(gameObject);
	}
}
