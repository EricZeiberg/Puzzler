using UnityEngine;
using System.Collections;

public class CameraJump : MonoBehaviour {

	public int speed;
	private CharacterController controller;
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
//		//if (controller.isGrounded) {
//			if (Input.GetKeyDown (KeyCode.Space)) {
//				Vector3 vector = transform.TransformDirection(Vector3.up);
//				controller.Move (vector * speed * Time.deltaTime);
//
//			}
//		//}
//
//		controller.Move (transform.up * (Vector3.zero.y - (800 * Time.deltaTime)) * Time.deltaTime);
	}
}
