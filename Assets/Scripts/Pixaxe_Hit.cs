using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pixaxe_Hit : MonoBehaviour {

	public int speed;
	public GameObject pixaxe;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (1)) {
			if (StaticVars.isPickedUp()) {
				iTween.RotateTo(pixaxe, new Vector3(0,0,327), 0.5);
				
				iTween.RotateTo(pixaxe, new Vector3(0,0,-16), 0.5);
			}

		}
	}

}
			