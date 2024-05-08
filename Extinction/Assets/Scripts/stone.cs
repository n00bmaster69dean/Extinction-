using UnityEngine;
using System.Collections;

public class stone : MonoBehaviour {
	Animator an;
	public movement1 player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<movement1>();
		an = GetComponent<Animator>();
		an.SetInteger ("animationstate", 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other){

		if (other.gameObject.tag == "Player") {
			if (player.space == true) {
				StartCoroutine (MyCoroutine ());
			}
		}
		}

	IEnumerator MyCoroutine(){
		yield return new WaitForSeconds (0.8f);
		{
			an.SetInteger ("animationstate", 1);
			}
		}
	}

