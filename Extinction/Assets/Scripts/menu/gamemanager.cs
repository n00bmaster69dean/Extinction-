using UnityEngine;
using System.Collections;

public class gamemanager : MonoBehaviour {
	public string pName;

	public static gamemanager instance = null;
	
	void Awake(){
		if (instance == null) {
			instance = this;
		}
		else if (instance != this){
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		spawningmeteors.score = 0;
	}

	void Update () {
	
	}
}
