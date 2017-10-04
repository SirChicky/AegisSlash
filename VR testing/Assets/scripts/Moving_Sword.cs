using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Sword :SteamVR_TrackedController 
{
	private SteamVR_TrackedObject trackedObj;
	public SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int) controllerIndex); } }
	public Vector3 velocity { get { return controller.velocity; } }
	public Vector3 angularVelocity { get { return controller.angularVelocity; } }
	//private SteamVR_Controller.Device controller;


	void Start()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject> ();
	}

	void FixedUpdate() 
	{
		//controller = SteamVR_Controller.Input((int)trackedObj.index);
	}

	void Update()
	{
		Debug.Log ("" + controller.velocity);
		Debug.Log ("" + controller.angularVelocity);
	}
}
