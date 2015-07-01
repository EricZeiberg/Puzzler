using UnityEngine;
using System.Collections;

public class SentryAI : MonoBehaviour {


	public float delay;
	public int projectileAmount = 1;
	public int minDistance = 100;

	public GameObject target;
	public GameObject original_Proj;

	float internalDelay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (target.transform.position, transform.position) <= minDistance) {
			Object proj = Instantiate(original_Proj, original_Proj.transform.position, original_Proj.transform.rotation);
		}
	}


}
