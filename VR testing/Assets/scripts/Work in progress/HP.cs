using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {
	public int hpPlayer;
	private int hpPlayerOrigin;

	private BulletMovement bulletMovementaccess;
	private Straight_BulletMovement straightBulletMovementaccess;
	// Use this for initialization
	void Awake () {
		hpPlayerOrigin = hpPlayer;
	}
	void Start(){
		hpPlayer = hpPlayerOrigin;
	}
	void Update(){
		//Debug.Log ("" + hpPlayer);	
	}

}
