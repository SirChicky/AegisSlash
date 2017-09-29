using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHapticPulse : MonoBehaviour {

	private ushort vibratingTime;
	SteamVR_TrackedObject trackedObj;

	void Awake ()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider Other)
	{
		if (Other.gameObject.CompareTag ("buncing")) {
			Debug.Log ("Wack!");
			vibratingTime = 180;
			SteamVR_Controller.Input ((int)trackedObj.index).TriggerHapticPulse (vibratingTime);
		}
	}
}