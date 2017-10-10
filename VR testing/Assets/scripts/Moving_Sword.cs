using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Sword :SteamVR_TrackedController 
{
	public GameObject bullet;
	public GameObject sword;
	public float limitx;
	public float limity;
	public float limitz;

	public float limitangx;
	public float limitangy;
	public float limitangz;

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

	void OnTriggerEnter(Collider Other)
	{
		
		if (controller.velocity.x<limitx)
			{
			sword.tag="IdleSword";
			if (Other.gameObject.CompareTag ("buncing")) {
				Debug.Log ("Destroy");
				Destroy (bullet);
			}
		}
		if (controller.velocity.y<limity)
		{
			sword.tag="IdleSword";
			if (Other.gameObject.CompareTag ("buncing")) {
				Debug.Log ("Destroy");
				Destroy (bullet);
			}
		}	
		if (controller.velocity.z<limitz)
		{
			sword.tag="IdleSword";//a creer
			if (Other.gameObject.CompareTag ("buncing")) {
				Debug.Log ("Destroy");
				Destroy (bullet);
			}
		}
		if (controller.velocity.x>limitangx)
		{
			//Debug.Log ("Star platinum");
		}
		if (controller.velocity.y>limitangy)
		{
			//Debug.Log ("Silver chariot");
		}	
		if (controller.velocity.z>limitangz)
		{
			//Debug.Log ("The world(O)");
		}
}
}
