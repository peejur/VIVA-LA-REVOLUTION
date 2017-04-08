using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

	public int timer = 0;

	
	// Update is called once per frame
	void Update () {
		Rigidbody rb = this.GetComponent<Rigidbody>();
		timer++;
		if (timer % 103 == 0)
			rb.AddForce (0, 0, timer);
		if (timer % 53 == 0)
			rb.AddForce (0, 0, -timer/2);
		
	}
}
