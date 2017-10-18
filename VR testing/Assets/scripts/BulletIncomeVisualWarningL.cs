﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletIncomeVisualWarningL : MonoBehaviour 
{
	public GameObject leftWarning;

	// Use this for initialization
	void Start () 
	{
		leftWarning.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}


	void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.tag == "Bullet") 
		{
			StartCoroutine ("Appear");
		}

	}

	IEnumerator Appear()
	{
		leftWarning.SetActive (true);
		yield return new WaitForSeconds (2f);
		leftWarning.SetActive (false);
		yield break;
	}


}