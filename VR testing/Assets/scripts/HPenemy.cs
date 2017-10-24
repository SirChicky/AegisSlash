using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPenemy : MonoBehaviour {
	public int hp;
	public int damages;
	// Update is called once per frame
	void Update () {
		//Debug.Log(""+ hp);
		if (hp <= 0) {
			Destroy(this.gameObject);

		}

		if (Input.GetButtonDown ("Fire1")) {
			Debug.Log ("Mort");
			Destroy (this.gameObject);
		}
	}
	void OnTriggerEnter(Collider Other)
	{
		if (Other.gameObject.CompareTag ("BulletBack")) {
			hp = hp - damages;
			//Debug.Log("touche");
		}
	}
}
