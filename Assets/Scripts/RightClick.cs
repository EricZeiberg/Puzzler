using UnityEngine;
using System.Collections;
using UnityEditor;

public class RightClick : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public GameObject parent_to;
	public GameObject hand_obj;

	public static bool pickedUp = false;
	
	void Update()
	{
		if (Input.GetMouseButton (0)) {
			ray = Camera.allCameras[0].ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit))
			{
				if (hit.collider.gameObject.tag.Equals("Holdable") && !pickedUp) {
					Vector3 colliderVector = hit.collider.gameObject.transform.position;
					hit.collider.gameObject.transform.SetParent(parent_to.transform);
					Quaternion rotation = hit.collider.gameObject.transform.rotation;
					hit.collider.gameObject.transform.localPosition = new Vector3(11, -15, 36);
					hit.collider.gameObject.transform.rotation = Quaternion.Euler(11, 8, -1);
					hand_obj.SetActive(false);
					pickedUp = true;
				}
			}
		}
	}
}
