using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization

    public float speed;
    private float moveInputX;
    private float moveInputY;

    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        moveInputX = Input.GetAxis("horizontal");
        moveInputY = Input.GetAxis("vertical");

        rb.velocity = new Vector2(moveInputX * speed, moveInputY * speed);
        //rb.transform.Translate();
	}
}
