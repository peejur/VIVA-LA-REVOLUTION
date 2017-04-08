using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveArrow : MonoBehaviour {
	public float MAX_DAMAGE = 90f;
	public float MAX_FORCE = 2000000f;
	public float areaOfEffect = 100f;
	void OnTriggerEnter(Collider other) {
		Collider[] cols = Physics.OverlapSphere (transform.position, areaOfEffect);
		foreach (Collider current in cols) {
			if (current.gameObject.tag == "Player") {
				float distanceCoef = (1 - Vector3.Distance (transform.position, current.transform.position) / areaOfEffect);
				float amount = MAX_DAMAGE * distanceCoef;
				current.GetComponent<PlayerState> ().TakeDamage (amount);
			}
		}
	}
}
