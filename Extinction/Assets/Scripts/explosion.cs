using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	AudioSource snd;
	[SerializeField] AudioClip explosions;

	// Use this for initialization
	void Start () {
		snd = GetComponent<AudioSource> ();
		if (this.gameObject.tag == "explosion"){
			snd.PlayOneShot (explosions);
	}
		
		DontDestroyOnLoad(gameObject);
		StartCoroutine (MyCoroutine ());
	}

	// Update is called once per frame
	void Update () {

	}
	IEnumerator MyCoroutine(){
		yield return new WaitForSeconds (5);{
			Destroy(gameObject);	
		}
	}
}
