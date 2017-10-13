using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Sword :SteamVR_TrackedController 
{
	//public GameObject sword;
	/*public float limitx;
	public float limity;
	public float limitz;*/

	public GameObject shadow;

	public float limitangx;
	public float limitangy;
	public float limitangz;

	private SteamVR_TrackedObject trackedObj;
	public SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int) controllerIndex); } }
	public Vector3 velocity { get { return controller.velocity; } }
	public Vector3 angularVelocity { get { return controller.angularVelocity; } }


	Vector3 previousPosition;
	[SerializeField]
	float movementThreshold;


	void Start()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject> ();
	}
		

	void Update()
	{
		//Debug.Log ("" + controller.velocity);
		//Debug.Log ("" + controller.angularVelocity);
		//Debug.Log (rb.velocity);
		float dist = Vector3.Distance (previousPosition, transform.position);
		if (dist < movementThreshold)
		{
			gameObject.tag = "IdleSword";
		}		

		else 
		{
			gameObject.tag="Sword";
			Instantiate (shadow);
		}


	}
	void LateUpdate()
	{
		previousPosition = transform.position;
	}

	void OnTriggerEnter(Collider Other)
	{
		


		

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
