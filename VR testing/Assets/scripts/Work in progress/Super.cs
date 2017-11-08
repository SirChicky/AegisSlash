using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super : MonoBehaviour {
	public float speed;
	public float selfDestruct;
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * (Time.deltaTime * speed);
		Destroy (this.gameObject,selfDestruct);
	}
}
