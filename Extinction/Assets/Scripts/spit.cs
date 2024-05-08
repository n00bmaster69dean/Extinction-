using UnityEngine;
using System.Collections;

public class spit : MonoBehaviour {
	public Rigidbody2D spitRB;
	private float speed;
	public enemy enemys;
	private bool wait = true;


	void Start () {
		enemys = FindObjectOfType<enemy> ();
		StartCoroutine (MyCoroutine ());
		speed = enemys.speed * 2f;
	}
	

	void Update () {
		spitRB.velocity = new Vector2 (speed, spitRB.velocity.y);
		if (wait == true) {
			wait = false;
		}
	}


	void OnTriggerStay2D(Collider2D other){

		if (other.gameObject.tag == "ground") {
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
	}

	IEnumerator MyCoroutine(){
		yield return new WaitForSeconds (5);
		{
			Destroy (this.gameObject);
		}
	}
}
