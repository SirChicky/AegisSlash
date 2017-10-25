using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMovementDetection :SteamVR_TrackedController  
{

	public Vector3 currentSpeed;
	//public GameObject parentSword;

	public float limitangx;
	public float limitangy;
	public float limitangz;
	public GameObject childSword;

	private SteamVR_TrackedObject trackedObj;
	public SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int) controllerIndex); } }
	public Vector3 velocity { get { return controller.velocity; } }
	public Vector3 angularVelocity { get { return controller.angularVelocity; } }


	Vector3 previousPosition;
	[SerializeField]
	float minMovementThreshold;
	[SerializeField]
	float maxMovementThreshold;


	void Start()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject> ();
		//instantiateTimer = 0.005f;
	}


	void Update()
	{
		Debug.DrawRay (transform.position, 3 * currentSpeed.normalized, Color.red, .1f);
		float dist = Vector3.Distance (previousPosition, transform.position);
		currentSpeed =  transform.position - previousPosition; 

		//instantiateTimer -= Time.deltaTime;
		if (dist < minMovementThreshold /*|| dist > maxMovementThreshold*/)
		{
			gameObject.tag = "IdleSword";
			childSword.tag = "IdleSword";

		}		

		else 
		{
			gameObject.tag ="Sword";
			childSword.tag = "Sword";
		}


	}
	void LateUpdate()
	{
		previousPosition = transform.position;
	}

}