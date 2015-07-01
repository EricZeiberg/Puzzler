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
				StartCoroutine(DoMoving());
				
			}

		}
	}

	IEnumerator DoMoving()
	{
		iTween.RotateTo(pixaxe, iTween.Hash ("z", 327, "isLocal", true, "time", 0.3f));
		yield return new WaitForSeconds(0.5f);
		iTween.RotateTo(pixaxe, iTween.Hash ("z", 358, "isocal", true, "time", 0.3f));
	}

}
			