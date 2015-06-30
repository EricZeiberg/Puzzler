using UnityEngine;
using System.Collections;

public class StaticVars : MonoBehaviour {

	 static bool pickedUp = false;

	public static void setPickedUp(bool picked) {
		pickedUp = picked;
	}

	public static bool isPickedUp() {
		return pickedUp;
	}
}
