using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour {

	public GameObject obj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Q) && StaticVars.isPickedUp()) {
			obj.transform.SetParent(null);
			obj.transform.rotation = Quaternion.Euler(275, 180, 180);
			Vector3 temp = obj.transform.position;
			temp.y = 2;
			obj.transform.position = temp;
			StaticVars.setPickedUp(false);
		}

	}
}
