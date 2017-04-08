using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAmmo : MonoBehaviour {
	public int amount = 5;
	public bool gaveAmmo = false;
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag != "Player")
			return;
		if (!gaveAmmo) {
			FireBow fb = other.GetComponentInChildren<FireBow> ();
			int currentSelection = fb.currentSelection;
			fb.ammo[currentSelection] += amount;
			gaveAmmo = true;
			Destroy (gameObject);
		}
	}
}
