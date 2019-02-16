using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    // Use this for initialization
    public float horizonralSpeed;
    public float verticalSpeed;

    float speedX;
    float speedY;

    public float verticalImpulse;
    public Rigidbody2D rb;
    public Camera cam;
    public GameObject camTrigger;
    public bool isGrounded;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W))
        {
            speedY = verticalSpeed;
        } else if (Input.GetKey(KeyCode.S))
        {
            speedY = -verticalSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            speedX = -horizonralSpeed;
        } else if (Input.GetKey(KeyCode.D))
        {
            speedX = horizonralSpeed;
        }
        transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, 0);
        cam.transform.position = camTrigger.transform.position;
        speedX = 0;
        speedY = 0;
	}

    
}
