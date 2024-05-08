using UnityEngine;
using System.Collections;

public class mainmusic : MonoBehaviour {
	public GameObject music;


	void Start () {
		DontDestroyOnLoad(gameObject);
	}

	void Update () {
		//DontDestroyOnLoad(gameObject);
		if (Application.loadedLevelName != "scene") {
			music.SetActive(true);
		}
	}
}
