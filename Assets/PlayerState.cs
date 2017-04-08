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

	private void Die(){
		return; //do nothing
	}
}
