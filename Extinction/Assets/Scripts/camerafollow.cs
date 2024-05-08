using UnityEngine;
using System.Collections;

public class camerafollow : MonoBehaviour {

	[SerializeField] Transform followplayer;
	[SerializeField] Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		followplayer.position = new Vector3 (0.2f, 4f+ player.position.y, -10);
	}
}
