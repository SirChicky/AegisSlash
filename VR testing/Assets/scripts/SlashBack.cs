using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashBack : MonoBehaviour {


	void OnTriggerEnter(Collider Other){
		if (Other.gameObject.tag == ("Sword") || (Other.gameObject.tag == ("IdleSword"))) {
			this.gameObject.tag = ("Sword");
		}
	} 

	void OnTriggerStay(Collider Other){
		if (Other.gameObject.tag == ("Sword")||(Other.gameObject.tag == ("IdleSword"))){
			this.gameObject.tag = ("Sword");
			} 
			

			else{
				
			this.gameObject.tag = ("Untagged");
		}
		
	}
}

