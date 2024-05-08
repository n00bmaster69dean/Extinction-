using UnityEngine;
using System.Collections;

public class help : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "stick man") {
			Application.LoadLevel ("help");
		}
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name == "stick man") {
			Application.LoadLevel ("help");
		}
	}
}
