using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlTimeController : MonoBehaviour
{
    public static float lvlTime = 1f;
    public float periodicityAddTime = 10f;
    public float timeCount = .016f;

    void Start()
    {
        DropTime();
        InvokeRepeating("AddTime", periodicityAddTime, periodicityAddTime);
    }

    void DropTime()
	{
        lvlTime = 1f;
	}

    void AddTime()
	{
        lvlTime += timeCount;
	}
}
