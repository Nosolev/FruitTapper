using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Fruits")]
    public List<GameObject> fruitReference;
    public float fruitSpawnTime = 1f;
    public byte fruitCount = 2;

    [Header("Bombs")]
    public GameObject bombReference;
    public float bombSpawnTime = 2f;
    public byte bombCount = 1;

    [Header("Coins")]
    public GameObject coinReference;
    public float coinSpawnTime = 1.5f;
    public byte coinCount = 2;

    void Start()
    {
        InvokeRepeating("SpawnFruit", fruitSpawnTime, fruitSpawnTime);
        InvokeRepeating("SpawnBomb", bombSpawnTime, bombSpawnTime);
        InvokeRepeating("SpawnCoin", coinSpawnTime, coinSpawnTime);
    }

    void Update()
    {

    }

    private void SpawnFruit()
	{
        for (byte i = 0; i < fruitCount; i++)
		{
            Instantiate(fruitReference[Random.Range(0, fruitReference.Count)]);
		}
	}

    private void SpawnBomb()
	{
        for (byte i = 0; i < bombCount; i++)
        {
            Instantiate(bombReference);
        }
    }

    private void SpawnCoin()
    {
        for (byte i = 0; i < coinCount; i++)
        {
            Instantiate(coinReference);
        }
    }
}
