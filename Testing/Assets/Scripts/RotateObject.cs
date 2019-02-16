using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {


    public float speed = 1f;

    private Transform target;
    

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        target.position = Input.mousePosition;

        
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(0, 0, direction.z));
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * speed);
	}
}
