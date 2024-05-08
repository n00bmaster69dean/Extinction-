using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spawningmeteors : MonoBehaviour {
	//test what one location(); does
	public Text countText;

	public static int score = 0;
	
	public Transform[] meteorpositions;

	public GameObject[] meteors;

	public int frequent = 2;
	private int ranspawnmeteor;
	private int rangameobject;
	private float ranwait;
	private int metorposition;
	private bool spawn = true;
	private int trap;
	private bool pos1 = true;
	private bool pos2 = true;
	private bool pos3 = true;
	private bool pos4 = true;
	private bool pos5 = true;
	private bool pos6 = true;
	private bool pos7 = true;
	private bool pos8 = true;
	private bool pos9 = true;
	private bool pos10 = true;
	private bool pos11 = true;
	private bool pos12 = true;
	private bool pos13 = true;
	private bool pos14 = true;
	private bool pos15 = true;
	private bool second = true;


	public int powerup = 0;


	void resest(){
		
		pos1 = true;
		pos2 = true;
		pos3 = true;
		pos4 = true;
		pos5 = true;
		pos6 = true;
		pos7 = true;
		pos8 = true;
		pos9 = true;
		pos10 = true;
		pos11 = true;
		pos12 = true;
		pos13 = true;
		pos14 = true;
		pos15 = true;


	}

	void Start () {
		
		StartCoroutine (MyCoroutine2 ());

	}
	void spawnmeteor(){
		StartCoroutine (MyCoroutine3 ());
	}

	void position(){
		ranspawnmeteor = Random.Range (0, 15); 

		if (ranspawnmeteor == 0){
			if(pos1 == true){
				{
					metorposition = 0;
					spawnmeteor();
					pos1 =false;
				}
			}
			else if (pos1 == false){ 
				ranspawnmeteor +=1;
			}
		}

		else if (ranspawnmeteor == 1){
			if(pos2 == true){
				{
					metorposition = 1;
					spawnmeteor();
					pos2 =false;
				}
			}
			else if (pos2 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 2){
			if(pos3 == true){
				{
					metorposition = 2;
					spawnmeteor();
					pos3 =false;
				}

			}
			else if (pos3 == false){ 
				ranspawnmeteor +=1;
			}
		}
		if (ranspawnmeteor == 3){
			if(pos4 == true){
				{
					metorposition = 3;
					spawnmeteor();
					pos4 =false;
				}

			}
			else if (pos4 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 4){
			if(pos5 == true){
				{
					metorposition = 4;
					spawnmeteor();
					pos5=false;
				}

			}
			else if (pos5 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 5){
			if(pos6 == true){
				{
					metorposition = 5;
					spawnmeteor();
					pos6 =false;
				}
			}
			else if (pos6 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 6){
			if(pos7 == true){
				{
					metorposition = 6;
					spawnmeteor();
					pos7 =false;
				}

			}
			else if (pos7 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 7){
			if(pos8 == true){
				{
					metorposition = 7;
					spawnmeteor();
					pos8 =false;
				}

			}
			else if (pos8 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 8){
			if(pos9 == true){
				{
					metorposition = 8;
					spawnmeteor();
					pos9 =false;
				}

			}
			else if (pos9 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 9){
			if(pos10 == true){
				{
					metorposition =9;
					spawnmeteor();
					pos10 =false;
				}

			}
			else if (pos10 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 10){
			if(pos11 == true){
				{
					metorposition =10;
					spawnmeteor();
					pos11 =false;
				}

			}
			else if (pos11 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 11){
			if(pos12 == true){
				{
					metorposition = 11;
					spawnmeteor();
					pos12 =false;
				}

			}
			else if (pos12 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 12){
			if(pos13 == true){
				{
					metorposition = 12;
					spawnmeteor();
					pos13 =false;
				}

			}
			else if (pos13 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 13){
			if(pos14 == true){
				{
					metorposition = 13;
					spawnmeteor();
					pos14 =false;
				}

			}
			else if (pos14 == false){ 
				ranspawnmeteor +=1;
			}
		}
		else if (ranspawnmeteor == 14){
			if(pos15 == true){
				{
					metorposition = 14;
					spawnmeteor();
					pos15 =false;
				}

			}
			else if (pos15 == false){ 
				ranspawnmeteor =1;
			}
		}
	}


	void Update () {
		countText.text = "Score: " + score;
		//print (frequent);
		if (spawn == true) {

			StartCoroutine (MyCoroutine ());
		}
	}
		

	IEnumerator MyCoroutine(){
		if (spawn == true) {
			spawn = false;
		}
		ranwait = Random.Range (0, 1.5f); 
		yield return new WaitForSeconds (ranwait);	{
				trap = Random.Range (0, 2); 

				if (frequent == 2) {
					resest();
					if (trap == 0) {
						position();
						
					}
					else if (trap == 1) {
						position();
						
						
					}
				}
				else if (frequent == 3) {
					resest();
					trap = Random.Range (0, 2); 
					if (trap == 0) {
						position();

					}
					else if (trap == 1) {
						position();
						position();
					}
				}
				else if (frequent == 4) {
					resest();
					trap = Random.Range (0, 2); 
					if (trap == 0) {
						position();
						position();
						
										
					}
					else if (trap == 1) {
						position();
						position();
						position();

						
					}
				}
				else if (frequent == 5) {
					resest();
					trap = Random.Range (0, 2); 
					if (trap == 0) {
						position();
						position();
						
						
						
					}

					else if (trap == 1) {
						position();
						position();
						position();
						
						
					}
				}

				else if (frequent == 6) {
					resest();
					trap = Random.Range (0, 2); 
					if (trap == 0) {
						position();
						position();
						position();
						


					}
					else if (trap == 1) {
						position();
						position();
						position();
						


					}
				}
				else if (frequent == 7) {
					resest();
					trap = Random.Range (0, 2); 
					if (trap == 0) {
						position();
						position();
						position();
						
						
					}

					else if (trap == 1) {
						position();
						position();
						position();
						position();
						

					}
				}
				else if (frequent == 8) {
					resest();
					trap = Random.Range (0, 2); 
					if (trap == 0) {
						position();
						position();
						position();
						
						
					}

					else if (trap == 1) {
						position();
						position();
						position();
						position();
						

					}
				}
			}
		ranwait = Random.Range (0, 1.5f); 
		yield return new WaitForSeconds (ranwait);
		{
				trap = Random.Range (0, 2); 

				if (frequent == 2) {
					resest();
				trap = Random.Range (0, 2); 
				if (trap == 0) {
					position();


				}
										
				}

				if (frequent == 3) {
					resest();
					trap = Random.Range (0, 2); 
					if (trap == 0) {
						position();

						
					}
					else if (trap == 1) {
						position();
						
					}
				}
				else if (frequent == 4) {
					resest();
					trap = Random.Range (0, 2); 
					if (trap == 0) {
						position();
						position();

					}
					else if (trap == 1) {
						position();
						
					}
				}
				else if (frequent == 5) {
					resest();
					trap = Random.Range (0, 2); 
				if (trap == 0) {
					position ();
					position ();
						
				}
				else if (trap == 1) {
						position();
						position();
						
					}
				}

				else if (frequent == 6) {
					resest();
					trap = Random.Range (0, 2); 
					if (trap == 0) {
						position();
						position();
						position();
						

					}
					else if (trap == 1) {
						position();
						position();
						
						


					}
				}
				else if (frequent == 7) {
					resest();
					trap = Random.Range (0, 2); 
				if (trap == 0) {
					position ();
					position ();



				} else if (trap == 1) {
					position ();
					position ();
					position ();
					position ();


				} else if (frequent == 8) {
					resest ();
					trap = Random.Range (0, 2); 
					if (trap == 0) {
						position ();
						position ();
						position ();




					} else if (trap == 1) {
						position ();
						position ();


					}
				}
			}

		yield return new WaitForSeconds (0.3f);
		{
			spawn = true;
		}
		}}

	IEnumerator MyCoroutine2(){
		yield return new WaitForSeconds (40);{
			frequent += 1;
		}
		yield return new WaitForSeconds (40);{
			frequent += 1;
			powerup = 1;
		}
		yield return new WaitForSeconds (40);{
			frequent += 1;
		}
		yield return new WaitForSeconds (40);{
			frequent += 1;
			powerup = 2;
		}
		yield return new WaitForSeconds (40);{
			frequent += 1;
		}
		yield return new WaitForSeconds (40);{
			frequent += 1;
		}
	
}

	IEnumerator MyCoroutine3(){
		ranwait = Random.Range (0, 0.5f);
		yield return new WaitForSeconds (ranwait);{
		ranspawnmeteor = Random.Range (-40, 60);
		rangameobject = Random.Range (0, 5);


		if (rangameobject == 0) {
			Instantiate (meteors[0], new Vector2 (meteorpositions[metorposition].transform.position.x, 
				meteorpositions[metorposition].transform.position.y), Quaternion.Euler(transform.rotation.x, transform.rotation.y, ranspawnmeteor));
		}
		else if (rangameobject == 1) {
			Instantiate (meteors[1], new Vector2 (meteorpositions[metorposition].transform.position.x, 
				meteorpositions[metorposition].transform.position.y), Quaternion.Euler(transform.rotation.x, transform.rotation.y, ranspawnmeteor));
		}
		else if (rangameobject == 2) {
			Instantiate (meteors[2], new Vector2 (meteorpositions[metorposition].transform.position.x, 
				meteorpositions[metorposition].transform.position.y), Quaternion.Euler(transform.rotation.x, transform.rotation.y, ranspawnmeteor));
		}
		else if (rangameobject == 3) {
			Instantiate (meteors[3], new Vector2 (meteorpositions[metorposition].transform.position.x, 
				meteorpositions[metorposition].transform.position.y), Quaternion.Euler(transform.rotation.x, transform.rotation.y, ranspawnmeteor));
		}
			
}
}
}
//ranspawnmeteor = Random.Range (0, 25); 
