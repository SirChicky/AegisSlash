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
	//public GameObject parentSword;

	public float limitangx;
	public float limitangy;
	public float limitangz;
	public float instantiateTimer;

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
		instantiateTimer = 0.01f;
	}
		

	void Update()
	{
		//Debug.Log ("" + controller.velocity);
		//Debug.Log ("" + controller.angularVelocity);
		//Debug.Log (rb.velocity);
		float dist = Vector3.Distance (previousPosition, transform.position);

		//var shadowPosition = new Vector3(parentSword.position.x, parentSword.position.y, parentSword.position.z);
		//var shadowRotation = Quaternion.identity;

		instantiateTimer -= Time.deltaTime;
		if (dist < movementThreshold)
		{
			gameObject.tag = "IdleSword";
		}		

		else 
		{
			gameObject.tag="Sword";
			if (instantiateTimer <= 0.0f) {
				Instantiate (shadow, transform.position, transform.rotation);
				instantiateTimer = 0.01f;
			}
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
