using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRotation : MonoBehaviour {
	public Quaternion targetRotation;
	public float smooth = 1f;
	public float gravity = Physics.gravity.y;
	public float finalVelocity = 0f;
	public float initialVelocity;
	public float time;
	private float angualrDrag;
	public bool flying = false;
	public float flightTime = 0.0f;
	public Rigidbody rb;

	// Update is called once per frame
	void Start() {
		rb = gameObject.GetComponent<Rigidbody> ();
		targetRotation = Quaternion.FromToRotation (transform.position, transform.forward);
	}

	void Update () {
		flightTime += Time.deltaTime;
		if (flying && flightTime > time) {
			transform.rotation = Quaternion.Lerp (transform.rotation, targetRotation, smooth * Time.deltaTime); 
		}
	}

	void OnTriggerEnter(Collider other) {
		flying = false;
	}

	public void setTime(){
		initialVelocity = rb.velocity.y;
		time = -initialVelocity / gravity;
	}
}
