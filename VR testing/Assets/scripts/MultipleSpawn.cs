using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleSpawn : MonoBehaviour {

	public GameObject enemy;
	private GameObject myenemy;
	public int numberenemies;
	public Transform[] spawnPoints;       
	public bool existence;
	public float timer;
	private float timerOrigin;
	private int numberenemiesOrigin;

	void Awake(){
		timerOrigin = timer;

	}
	void Start(){
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		myenemy = Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		numberenemies = numberenemies -1;

	}

	void Update () {
		// If the player has no health left...
		if(existence==true && enemy==true)
		{

			timer= timer-(Time.deltaTime);
			if (timer <= 0 && numberenemies>0) {
				// Find a random index between zero and one less than the number of spawn points.
				int spawnPointIndex = Random.Range (0, spawnPoints.Length);

				// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
				myenemy = Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
				numberenemies = numberenemies-1;
				timer = timerOrigin;

			}

			}
		if (numberenemies <=0 && GameObject.FindGameObjectWithTag("Enemy")==null) {
			Destroy (this.gameObject);
		}

	}
}