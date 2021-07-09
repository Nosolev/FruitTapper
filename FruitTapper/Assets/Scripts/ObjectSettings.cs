using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSettings : MonoBehaviour
{
    public float minSpeed = 2f;
    public float maxSpeed = 5f;
    public float spawnRange = 1f;
    public GameObject particleSystem;
    private float speed;
    private Rigidbody2D objectBody;
    
    void Start()
    {
        objectBody = GetComponent<Rigidbody2D>();
        speed = Random.Range(minSpeed, maxSpeed);
        transform.localPosition = new Vector2(Random.Range(-2.4f, 2.4f), Random.Range(GetCameraSize.topOfCamera, GetCameraSize.topOfCamera + spawnRange));
        objectBody.velocity = Vector2.down * speed * LvlTimeController.lvlTime;
    }

    void Update()
    {
        
        if (transform.localPosition.y <= GetCameraSize.botOfCamera)
		{
            Destroy(gameObject);
		}
    }

    public virtual void OnMouseDown()
    {
        Instantiate(particleSystem, transform.position, Quaternion.identity);
    }
}