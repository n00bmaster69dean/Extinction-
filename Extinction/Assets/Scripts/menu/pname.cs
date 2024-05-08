using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pname : MonoBehaviour {
	//public Text myname;
	public InputField iField;


	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		print ("playername = "+name);
	}
	public void TextChanged(string newText){
		gamemanager.instance.pName = iField.text;
		PlayerPrefs.SetString ("Playername", gamemanager.instance.pName);
		name = PlayerPrefs.GetString ("Playername");
	}
		//myname.text = name;

	public void ButtonPressed(){
		spawningmeteors.score = 0;
		Application.LoadLevel ("scene");
	}
}
