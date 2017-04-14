using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fallingdamage : MonoBehaviour {

	// Use this for initialization
	public double oldVelocity;

	public PlayerState ps;
	public CharacterController cc;
	void Start () {
		ps = GetComponent<PlayerState> ();

	}
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs((float)(cc.velocity.y - oldVelocity)) > 15)
			ps.TakeDamage (Mathf.Abs(((float)oldVelocity * 2)));
		oldVelocity = cc.velocity.y;
	}

	void OnGUI() {
		GUI.Label (new Rect (0, 100, 200, 100), "Velocity: " + cc.velocity.y + " " + oldVelocity + " ");

	}
}
