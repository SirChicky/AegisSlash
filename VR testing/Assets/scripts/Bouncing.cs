using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour {
	private Collision collision;
	public Rigidbody bulletback;
	public float power;



	void start (){
		DestroyObject (gameObject, 100.0f);
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "buncing"){
			GetComponent<Rigidbody> ().velocity *= -1;
			Debug.Log ("bungie_gum");
	}
}
}
		
	
