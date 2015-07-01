using UnityEngine;
using System.Collections;
using UnityEditor;

public class RightClick : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public GameObject parent_to;
	public GameObject hand_obj;
	public GameObject picaxe;
	
	void Update()
	{

		if (Input.GetMouseButton (0)) {
			ray = Camera.allCameras[0].ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit, 150))
			{
				if (hit.collider.gameObject.tag.Equals("Holdable") && !StaticVars.isPickedUp()) {
					Vector3 colliderVector = hit.collider.gameObject.transform.position;
					hit.collider.gameObject.transform.SetParent(parent_to.transform);
					Quaternion rotation = hit.collider.gameObject.transform.rotation;
					hit.collider.gameObject.transform.localPosition = new Vector3(11, -15, 36);
					hit.collider.gameObject.transform.localRotation = Quaternion.Euler(359, 238, 16);
					hand_obj.SetActive(false);
					StaticVars.setPickedUp(true);
				}
			}
		}
	}
}
