using UnityEngine;
using System.Collections;

public class SentryAI : MonoBehaviour {


	public float delay;
	public int projectileAmount = 1;
	public int minDistance = 100;
	public int speed = 50;

	public GameObject target;
	public GameObject original_Proj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (target.transform.position, transform.position) <= minDistance) {
			StartCoroutine(Shoot());
		}
	}

	IEnumerator Shoot()
	{
		for (float timer = delay; timer >= 0; timer -= Time.deltaTime)
			yield return 0;

		GameObject proj = Instantiate(original_Proj, original_Proj.transform.position, original_Proj.transform.rotation) as GameObject;
		proj.GetComponent<Rigidbody>().AddForce(Vector3.up + Vector3.forward * speed);

	}
}
