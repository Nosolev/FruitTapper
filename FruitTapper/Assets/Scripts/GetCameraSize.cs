using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCameraSize : MonoBehaviour
{
    private Camera componentCamera;
	private float cameraSize;
	public static float topOfCamera;
	public static float botOfCamera;

    void Start()
	{
		Invoke("SetCameraSize", .1f);
	}

	void SetCameraSize()
	{
		componentCamera = GetComponent<Camera>();
		cameraSize = componentCamera.orthographicSize;
		topOfCamera = cameraSize + .5f;
		botOfCamera = cameraSize * -1f - .5f;
	}
}
