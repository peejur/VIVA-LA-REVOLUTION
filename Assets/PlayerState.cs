using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {
	public float MAX_HEALTH = 100f;
	public float currentHealth;

	void Start() {
		currentHealth = MAX_HEALTH;
	}

	public void TakeDamage(float amount){
		currentHealth -= amount;
		if (currentHealth <= 0f)
			Die ();
	}
	void OnGUI() {
		GUI.Label (new Rect (0, 0, 200, 100), "Health: " + currentHealth);

	}

	private void Die(){
		GetComponent<CharacterController> ().enabled = false;
		GetComponent<Animator> ().Play("DEATH");
		return; //do nothing
	}
}
