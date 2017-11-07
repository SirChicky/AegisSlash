using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSuper : MonoBehaviour {
	public bool activation;
	public float timer;
	public GameObject Super;
	private float originTimer;
	void Awake(){
		originTimer = timer;

	}
	void Start(){
		activation = false;
		timer = 0;
		Debug.Log ("waiting time:" + timer);
	}
	// Update is called once per frame
	void Update () {
		if (timer > 0) {
			timer = timer - (1* Time.deltaTime);
		}
		if (timer<= 0 && activation == true) {
			Vector3 start = transform.position;

			{
				GameObject obj = (GameObject)Instantiate (Super, start, transform.rotation);
				timer = originTimer;
				activation = false;


		}
	}
}
}
