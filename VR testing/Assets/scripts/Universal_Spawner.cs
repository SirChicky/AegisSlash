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
		private bool stop;
		private bool stopTheMachine;
		private int spawnsNumber2;
		public int spawnsStart;
		void Awake(){
			spawnsOrigin = 0;
			spawnsNumber = spawnsOrigin;
			stopTheMachine = false;
			stop = false;
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
			FailSafe ();
			FailSafe2 ();
			spawnsNumber2.Equals (GameObject.FindGameObjectWithTag ("Enemy"));
			if (stopTheMachine == false) {
				if (inGroup [0] = true) {
					spawnsNumber = 0;
					if ((spawnsNumber2 == spawnsNumber) || grouped [0] == true) {
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
			if (stopTheMachine == false) {
				if (inGroup [0] = false ) {
					if ((spawnsNumber != spawnsNumber2) || grouped [0] == true) {
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
		}
		void Spawn(){
			Instantiate (enemies[0],spawnposition[0]);
			enemies.Remove(enemies[0]) ;
			spawnposition.Remove(spawnposition[0]);
			timer.Remove (timer [0]);
			grouped.Remove(grouped[0]);
			inGroup.Remove (inGroup [0]);

		}
		void FailSafe(){
			if (stopTheMachine == false) {
				if (enemies.Count == 1 || timer.Count == 1 || grouped.Count == 1 || spawnposition.Count == 1 || grouped.Count == 1 || inGroup.Count == 1) {
					Debug.Log ("the end");
					if (stop == true) {
						stopTheMachine = true;
					}

				}
			}
		}
		void FailSafe2(){
			if (stopTheMachine == false&&stop==false) {
				if (enemies.Count ==2 || timer.Count == 2 || grouped.Count == 2 || spawnposition.Count == 2 || grouped.Count == 2 || inGroup.Count == 2) {
					Debug.Log ("the end");
					enemies.Add (enemies [1]);
					spawnposition.Add(spawnposition[1]);
					timer.Add(timer [1]);
					grouped.Add(grouped[1]);
					inGroup.Add (inGroup [1]);
					stop = true;

				}
			}
			
		}
	}