using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour 
{
	public GameObject _target;
	public GameObject _newTarget;
	public Transform target;
	public Transform newTarget;
	public Vector3 targetPosition;
	public float speed;
	// Use this for initialization
	void Start () 
	{
		_target = GameObject.FindWithTag ("Player");
		target = _target.transform;
		targetPosition = _target.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		//targetPosition = new Vector3 (_target.transform.position.x, _target.transform.position.y, _target.transform.position.z);
		//targetPosition = _target.transform.position;
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, targetPosition, step);

	}

	void OnTriggerEnter(Collider Other)
	{
		if (Other.gameObject.CompareTag ("Player")) {
			Debug.Log ("Poke");
			Destroy (gameObject);

		}

		if (Other.gameObject.CompareTag ("Sword")) {
			Debug.Log ("Whack");
			speed = -speed;
			gameObject.tag = ("BulletBack");
			//Debug.Log("ORA");
			//float step = speed * Time.deltaTime;
			//transform.position = Vector3.MoveTowards (transform.position, newTarget.position, step);

		}

		if (Other.gameObject.CompareTag ("BulletDetector")) {
			Debug.Log ("Beep!");
			gameObject.tag = ("BulletDetected");
		}

		if (Other.gameObject.tag == "IdleSword") {
			Destroy (this.gameObject);
			//Debug.Log ("KIKOO");
		}
		if (Other.gameObject.tag == "Enemy") {
			Destroy (this.gameObject, 3.0f);
			//Debug.Log ("JOJO");
		}
		if (Other.gameObject.tag == "Detection") {
			Light lightComp = this.gameObject.AddComponent<Light>();
			lightComp.color = Color.blue;
		
		}
	}
		
}


