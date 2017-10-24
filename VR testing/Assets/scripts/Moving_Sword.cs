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
	public Vector3 currentSpeed;
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
		Debug.DrawRay (transform.position, 3 * currentSpeed.normalized, Color.red, .1f);
		//Debug.Log ("" + controller.velocity);
		//Debug.Log ("" + controller.angularVelocity);
		//Debug.Log (rb.velocity);
		float dist = Vector3.Distance (previousPosition, transform.position);
		currentSpeed =  transform.position - previousPosition; 
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
		
		if (Other.tag == "Bullet") {
			/*Vector3 bulletDir = Other.attachedRigidbody.velocity;
			Vector3 swordRot = new Vector3 (transform.rotation.x, transform.rotation.y, transform.rotation.z);
			bulletDir -= swordRot;
			Other.attachedRigidbody.velocity = bulletDir;*/
			//Debug.Break ();
		}

	}
}
