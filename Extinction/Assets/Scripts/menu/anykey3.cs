using UnityEngine;
using System.Collections;

public class anykey3 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			Application.LoadLevel("tips");
			Time.timeScale = 1;
		}
		
	}
}
