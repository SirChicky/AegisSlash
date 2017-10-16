using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletIncomeVisualWarningR : MonoBehaviour 
{
	public GameObject rightWarning;


	// Use this for initialization
	void Start () 
	{
		rightWarning.SetActive (false);
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
		rightWarning.SetActive (true);
		yield return new WaitForSeconds (2f);
		rightWarning.SetActive (false);
		yield break;
	}
}
