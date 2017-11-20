using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universal_Spawner : MonoBehaviour {

		public List<float> timer = new List<float> ();
		public List<GameObject> enemies = new List<GameObject> ();
		public List<Transform> spawnposition = new List<Transform> ();
		public List<bool> grouped = new List<bool> ();
	    public List<bool> inGroup = new List<bool> ();
		private int spawnsOrigin;
		private int spawnsNumber;
		private int spawnsNumber2;
		public int spawnsStart;
		void Awake(){
			spawnsOrigin = 0;
			spawnsNumber = spawnsOrigin;
		}

		void Start () {
			if (spawnsStart > 0) {
				Spawn ();
				spawnsStart -= 1;
				spawnsNumber = spawnsStart;
			}
		if (spawnsStart == 0) {
			spawnsNumber = 1;
		}
		}

		void Update () {
			//FailSafe ();
			spawnsNumber2.Equals (GameObject.FindGameObjectWithTag ("Enemy"));
		if (inGroup[0] = true) {
			spawnsNumber = 0;
			if ((spawnsNumber2 ==spawnsNumber) || grouped [0] == true) {
				if (spawnsStart <= 0 && spawnsNumber <= 0) {
					timer [0] -= Time.deltaTime;
					if (timer [0] <= 0.0f) {
						Spawn ();
						spawnsNumber = spawnsNumber2;
					}
				}
			}
		}
		if (inGroup[0]=false){
			if ((spawnsNumber != spawnsNumber2)||grouped[0]==true) {
				if (spawnsStart <= 0 && spawnsNumber <= 0) {
					timer [0] -= Time.deltaTime;
					if (timer [0] <= 0.0f) {
						Spawn ();
						spawnsNumber = spawnsNumber2;
					}
				  }
				}
			}
		}

		void Spawn(){
			Instantiate (enemies[0],spawnposition[0]);
			enemies.Remove(enemies[0]) ;
			spawnposition.Remove(spawnposition[0]);
			timer.Remove (timer [0]);
			grouped.Remove(grouped[0]);
		    inGroup.Remove (inGroup [0]);
		    
		}
		//void FailSafe(){
		//if (enemies [0].Equals( enemies.FindLastIndex(enemies))){
		///	enemies.Add (enemies [0]);
		///timer.Add (timer [0]);
		//spawnposition.Add (spawnposition [0]);
		//}


		//}
	}