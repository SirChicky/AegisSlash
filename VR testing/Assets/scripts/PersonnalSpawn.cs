using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonnalSpawn : MonoBehaviour {
	
		     // Reference to the player's heatlh.
		public GameObject enemy;
		private GameObject myenemy;// The enemy prefab to be spawned.
		//public float spawnTime = 3f;            // How long between each spawn.
		public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	    public bool existence;

		void Update ()
		{
			// If the player has no health left...
		if(existence==true && myenemy==null)
			{

			// Find a random index between zero and one less than the number of spawn points.
	      	int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
			myenemy = Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);	}
		}
	}

