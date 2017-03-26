using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetting : MonoBehaviour {
	public Transform target;
	public float range =8f;
	public float rotationSpeed = 100f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float distance = Vector3.Distance (transform.position, target.position);

		if (distance <= range) {
			
			//transform.LookAt (target);
			Vector3 direction = transform.position - target.position;
			Quaternion desiredRotation = Quaternion.LookRotation (direction, Vector3.up);

			transform.rotation = Quaternion.RotateTowards (transform.rotation, desiredRotation, rotationSpeed*Time.deltaTime);


		}
	}
}
