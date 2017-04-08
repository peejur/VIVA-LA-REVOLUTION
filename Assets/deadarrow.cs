using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deadarrow : MonoBehaviour {
	public float time = 0.0f;
	public GameObject hitEffect;
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "quiver")
			return;
		Rigidbody rb = this.GetComponent<Rigidbody>();
		rb.constraints = RigidbodyConstraints.FreezeAll;
		rb.useGravity = false;
		this.GetComponent<SphereCollider> ().enabled = false;
		this.transform.parent = other.transform;
		if (hitEffect) {
			Instantiate (hitEffect, transform.position,Quaternion.identity);
			Destroy (gameObject);
		}
	}
}
