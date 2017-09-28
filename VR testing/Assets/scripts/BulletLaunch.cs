using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLaunch : MonoBehaviour 
{
	public GameObject bullet;
	private Vector3 target;
	private Vector3 spawn;

	// Use this for initialization
	void Start () 
	{
		





	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			Vector3 start = transform.position;

			{
				GameObject obj = (GameObject)Instantiate (bullet, start, transform.rotation);
			}

		}

	}
}
