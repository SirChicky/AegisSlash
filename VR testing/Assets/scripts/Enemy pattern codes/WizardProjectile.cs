﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardProjectile : MonoBehaviour 
{
	public float timer;

	// Use this for initialization
	void Start () 
	{
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer = timer + 1;

		if (timer == 150) 
		{
			Destroy (this.gameObject);

		}
	}
}