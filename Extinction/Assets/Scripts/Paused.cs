using UnityEngine;
using System.Collections;

public class Paused : MonoBehaviour {

	public GameObject pause;
	private bool paused = false;


	void Start () {
		pause.SetActive (false);
	
	}
	

	void Update () {
		if (Input.GetKeyDown ("p") ||(Input.GetButtonDown ("Esc") )){
			paused = !paused;
		}

		if (paused) {

			pause.SetActive (true);
			Time.timeScale = 0;
		}

		if (!paused) {

			pause.SetActive (false);
			Time.timeScale = 1;
		}
	
	}
	public void Resume(){
		paused = false;

	}
	public void Restart(){
		//Application.LoadLevel ("scene");
	}

	public void Menu(){
		//Application.LoadLevel ("mainmenu");

	}
}
