using UnityEngine;
using System.Collections;

public class ProjectileAI : MonoBehaviour {

	public float speed = 500f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
		print ("Sent!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
