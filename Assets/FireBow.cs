using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBow : MonoBehaviour {
	public const int MAX_AMMO = 30;
	public List<int> ammo;
	public GameObject[] ammoTypes;
	public int currentSelection = 0;
	public GameObject arrowspawn;
	public float arrowforce;
	public float drawtime = 0.0f;
	public float MAX;
	public float temp;
	public float flightCriticalPoint;
	public float flightTime;
	private ArrowRotation mostReceentArrowFired;
	public bool setTime = true;

	void Start() {
		ammo = new List<int> ();
		for (int i = 0; i < ammoTypes.Length; i++) {
			ammo.Add (0);
		}
		ammo [0] = 10;
	}

	// Update is called once per frame
	void Update () {
		if (Input.mouseScrollDelta.y > 0) {
			currentSelection++;
			currentSelection = currentSelection % ammoTypes.Length;
		} else if (Input.mouseScrollDelta.y < 0) {
			currentSelection--;
			currentSelection = (currentSelection + ammoTypes.Length) % ammoTypes.Length;
		}

		if (mostReceentArrowFired != null) {
			flightCriticalPoint = mostReceentArrowFired.time;
			flightTime = mostReceentArrowFired.flightTime;
			if (mostReceentArrowFired.rb.velocity.y != 0.0f && setTime) {
				mostReceentArrowFired.setTime ();
				setTime = false;
			}
		}
		if(Input.GetMouseButton(0)){
			drawtime += Time.deltaTime;
		}
		if (Input.GetMouseButtonUp (0)) {
			if (ammo[currentSelection] <= 0)
				return;
			ammo[currentSelection]--;
			drawtime += .2f;
			float force = arrowforce * drawtime;
			if (force >= MAX)
				force = MAX;
			temp = force;//debug purposes
			GameObject firedarrow = Instantiate(ammoTypes[currentSelection], arrowspawn.transform.position,arrowspawn.transform.rotation);
			Rigidbody rb = firedarrow.GetComponent<Rigidbody>();
			rb.AddForce(-arrowspawn.transform.up*force, ForceMode.Impulse);
			mostReceentArrowFired = firedarrow.GetComponent<ArrowRotation>();
			setTime = true;
			drawtime = 0.0f;
		}
	}
}
