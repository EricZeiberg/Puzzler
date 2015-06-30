using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public int speed;
	public int rotation_speed;
	public int lock_y;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController controller = GetComponent<CharacterController>();

		if (Input.GetKey (KeyCode.W)) {
			Vector3 vector = transform.TransformDirection(Vector3.forward);
			vector.y = 0f;
			controller.Move (vector * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.S)) {
			Vector3 vector = transform.TransformDirection(Vector3.back);
			vector.y = 0f;
			controller.Move (vector * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.A)) {
			Vector3 vector = transform.TransformDirection(Vector3.left);
			vector.y = 0f;
			controller.Move (vector * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.D)) {
			Vector3 vector = transform.TransformDirection(Vector3.right);
			vector.y = 0f;
			controller.Move (vector * speed * Time.deltaTime);
		}

		if (Input.GetMouseButton(0)) {
			transform.rotation.Set(transform.rotation.x, transform.rotation.y + rotation_speed, transform.rotation.z, transform.rotation.w);
		}

		//transform.position = new Vector3(transform.position.x, lock_y, transform.position.z);

	}


}
