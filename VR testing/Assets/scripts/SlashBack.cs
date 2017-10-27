using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashBack : MonoBehaviour {


	void OnTriggerEnter(Collider Other){
		if (Other.gameObject.tag == ("Sword") || (Other.gameObject.tag == ("IdleSword"))) {
			this.gameObject.tag = ("Sword2");
		}
	} 

	void OnTriggerStay(Collider Other){
		if (Other.gameObject.tag == ("Sword")||(Other.gameObject.tag == ("IdleSword"))){
			this.gameObject.tag = ("Sword2");
			} 
			

			else{
				
			this.gameObject.tag = ("Untagged");
		}
		
	}
}

