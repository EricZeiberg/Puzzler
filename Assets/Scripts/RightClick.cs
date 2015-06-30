using UnityEngine;
using System.Collections;

public class RightClick : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public GameObject parent_to;
	
	void Update()
	{
		if (Input.GetMouseButton (0)) {
			ray = Camera.allCameras[0].ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit))
			{
				if (hit.collider.gameObject.tag.Equals("Holdable")) {
					hit.collider.transform.parent.SetParent(parent_to.transform);
				}
			}
		}
	}

	void OnMouseDown() {



	}
}
