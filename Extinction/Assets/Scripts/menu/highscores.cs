using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highscores : MonoBehaviour {
	public int Currenthighscore;
	public Text highscore1;
	public int Currenthighscore2;
	public Text highscore2;
	public int Currenthighscore3;
	public Text highscore3;
	public Text name1;
	public Text name2;
	public Text name3;
	private string Name1;
	private string Name2;
	private string Name3;
	
	void Start () {
		// RESETS THE HIGHSCORES
		//PlayerPrefs.SetInt ("Highscore",3);
		//PlayerPrefs.SetInt ("Highscore2",2);
		//PlayerPrefs.SetInt ("Highscore3",1);

		//PlayerPrefs.SetString ("Highscorename"," a");
		//PlayerPrefs.SetString ("Highscorename2"," b");
		//PlayerPrefs.SetString ("Highscorename3"," c");
		
		Currenthighscore = PlayerPrefs.GetInt("Highscore");
		Currenthighscore2 = PlayerPrefs.GetInt("Highscore2");
		Currenthighscore3 = PlayerPrefs.GetInt("Highscore3");

		Name1 = PlayerPrefs.GetString("Highscorename");
		Name2 = PlayerPrefs.GetString("Highscorename2");
		Name3 = PlayerPrefs.GetString("Highscorename3");


//		PlayerPrefs.SetString("PlayerName", gamemanager.pName);
//		name1.text = (gamemanager.pName);
//		PlayerPrefs.SetString("PlayerName2", gamemanager.pName2);
//		name2.text = (gamemanager.pName2);
//		PlayerPrefs.SetString("PlayerName3", gamemanager.pName3);
//		name3.text = (gamemanager.pName3);

		highscore1.text = "HIGHSCORE 1 = "+Currenthighscore;
		highscore2.text = "HIGHSCORE 2 = "+Currenthighscore2;
		highscore3.text = "HIGHSCORE 3 = "+Currenthighscore3;

		name1.text = Name1;
		name2.text = Name2;
		name3.text = Name3;

		
	}

	void Update () {
		
	}
}
