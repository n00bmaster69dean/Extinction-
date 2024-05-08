using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scores1 : MonoBehaviour {
	public Text scores;

	// Use this for initialization
	void Start () {
		scores.text = spawningmeteors.score.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
