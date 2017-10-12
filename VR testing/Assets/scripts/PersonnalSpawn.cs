using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonnalSpawn : MonoBehaviour {
	public  GameObject Enemy;
	public float Timer;
	public string objectToFind;
	void Awake() {
		Timer = Time.time + 3;
	}

	void Update() {
		if (Timer < Time.time && !GameObject.Find(objectToFind)) { //This checks wether real time has caught up to the timer
			Instantiate(Enemy, transform.position, transform.rotation);//This spawns the emeny
			//Timer = Time.time + 3; //This sets the timer 3 seconds into the future
		}
	}

}
