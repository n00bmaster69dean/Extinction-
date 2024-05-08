using UnityEngine;
using System.Collections;

public class anykey2 : MonoBehaviour {
	public int Currenthighscore;
	public int Currenthighscore2;
	public int Currenthighscore3;
	bool no =false;

	void Start () {
		Currenthighscore = PlayerPrefs.GetInt("Highscore");
		Currenthighscore2 = PlayerPrefs.GetInt("Highscore2");
		Currenthighscore3 = PlayerPrefs.GetInt("Highscore3");

		if (spawningmeteors.score > Currenthighscore){
				string Name1 = PlayerPrefs.GetString("Highscorename");
				PlayerPrefs.SetString("Highscorename",Name1);
			PlayerPrefs.SetInt ("Highscore", spawningmeteors.score);
			PlayerPrefs.SetString("Highscorename",gamemanager.instance.pName);
		}
		if (spawningmeteors.score < Currenthighscore){
			if (spawningmeteors.score > Currenthighscore2){
				if(Currenthighscore != Currenthighscore2){
					if(Currenthighscore2 >Currenthighscore3){
						PlayerPrefs.SetInt ("Highscore3", Currenthighscore2);
						string Name3 = PlayerPrefs.GetString("Highscorename2");
						PlayerPrefs.SetString("Highscorename3",Name3);
						no =true;
					}
					PlayerPrefs.SetInt ("Highscore2", spawningmeteors.score);
					PlayerPrefs.SetString("Highscorename2", gamemanager.instance.pName);
					
				}
			}
		}
		if (spawningmeteors.score < Currenthighscore){
			if (spawningmeteors.score < Currenthighscore2){
				if (spawningmeteors.score > Currenthighscore3){
					if(Currenthighscore2 != Currenthighscore3){
						if(no==false){
							PlayerPrefs.SetInt ("Highscore3", spawningmeteors.score);
							PlayerPrefs.SetString("Highscorename3",gamemanager.instance.pName);
						}
					}
				}
			}
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			Application.LoadLevel("highscores");
			Time.timeScale = 1;
		}
		
	}
}
