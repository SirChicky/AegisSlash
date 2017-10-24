using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashBack : MonoBehaviour {


	void OnTriggerEnter (Collider Other){
		if (Other.gameObject.tag == ("Sword")) {
			this.gameObject.tag = ("Sword");

		
		} 
			if (Other.gameObject.tag == ("IdleSword"))
			{

				this.gameObject.tag=("idleSword");
			}

			else {
			this.gameObject.tag = ("Untagged");
		}
		
	}
}

