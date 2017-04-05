using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBow : MonoBehaviour {

	public GameObject arrowspawn;
	public GameObject arrow;
	public float arrowforce;
	public float drawtime = 0.0f;
	public float MAX;
	public float temp;
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){
			drawtime += Time.deltaTime;

		
		}
		if (Input.GetMouseButtonUp (0)) {
			drawtime += .2f;
			float force = arrowforce * drawtime;
			if (force >= MAX)
				force = MAX;
			temp = force;//debug purposes
			GameObject firedarrow = Instantiate(arrow, arrowspawn.transform.position,arrowspawn.transform.rotation);
			Rigidbody rb = firedarrow.GetComponent<Rigidbody>();
			rb.AddForce(-arrowspawn.transform.up*force, ForceMode.Impulse);
			drawtime = 0.0f;

		}
	}
}
