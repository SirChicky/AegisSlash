using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Sword :SteamVR_TrackedController {


		public SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int) controllerIndex); } }
		public Vector3 velocity { get { return controller.velocity; } }
		public Vector3 angularVelocity { get { return controller.angularVelocity; } }

		void update(){
			Debug.Log ("" + controller.velocity);
			Debug.Log ("" + controller.angularVelocity);

		}

	}
