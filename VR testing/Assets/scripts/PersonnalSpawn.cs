using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonnalSpawn : MonoBehaviour {
	public  GameObject enemy;
	private GameObject myenemy;

	void Update() {
		if (myenemy==null) { //This checks wether real time has caught up to the timer
			myenemy=Instantiate(enemy, transform.position, transform.rotation);//This spawns the emeny

	}

}
}
