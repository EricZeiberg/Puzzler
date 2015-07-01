using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Explosion : MonoBehaviour {
	
	Ray ray;
	RaycastHit hit;
	public int health = 5;


	int currentHealth;
	void start() {
		 currentHealth = health;
		//text.gameObject.SetActive (false);

	}

	void Update()
	{
		
		if (Input.GetMouseButtonDown (1)) {
			ray = Camera.allCameras[0].ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit))
			{
				if (hit.collider.gameObject.tag.Equals("Breakable") && StaticVars.isPickedUp()) {
					currentHealth -= 1;
					if (currentHealth == -5) {
						hit.collider.gameObject.SetActive(false);
					}
				}
			}
		}
	}
}
