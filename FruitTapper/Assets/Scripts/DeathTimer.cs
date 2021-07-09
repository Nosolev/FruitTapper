using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTimer : MonoBehaviour
{
    public static float deathTime = 60f;

    void Start()
    {
        deathTime = 60f;
    }

    void Update()
    {
        deathTime -= Time.deltaTime;
        if (deathTime <= 0)
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public static void AddTime()
	{
        if (deathTime < 59.1f)
		{
            deathTime += 1f;
		}
	}

    public static void ReduceTime()
	{
        deathTime -= 1f;
	}
}
