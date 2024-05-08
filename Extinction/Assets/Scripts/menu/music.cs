using UnityEngine;
using System.Collections;


public class music : MonoBehaviour {
	public static music instance = null;
	
	void Awake(){
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}


	void Start(){
	}
	
	void Update(){
		DontDestroyOnLoad(gameObject);

		if (Application.loadedLevelName == "highscores") {
			DontDestroyOnLoad(gameObject);
		}
		if (Application.loadedLevelName == "mainmenumusic") {
			//gameObject.SetActive(true);
		}
		if (Application.loadedLevelName == "levelselect") {
			DontDestroyOnLoad(gameObject);
		}
		if (Application.loadedLevelName == "mainmenu") {
			DontDestroyOnLoad(gameObject);
		}
		if (Application.loadedLevelName == "play") {
			DontDestroyOnLoad(gameObject);
		}
		if (Application.loadedLevelName == "options") {
			DontDestroyOnLoad (gameObject);
		} 
		if (Application.loadedLevelName == "scene") {
			gameObject.SetActive(false);
		} 
	}

}