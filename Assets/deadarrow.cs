using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadarrow : MonoBehaviour {
	public float time = 0.0f;
	void OnTriggerEnter(Collider other){
		Rigidbody rb = this.GetComponent<Rigidbody>();
		rb.constraints = RigidbodyConstraints.FreezeAll;
		rb.useGravity = false;
		this.GetComponent<SphereCollider> ().enabled = false;
		this.transform.parent = other.transform;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
