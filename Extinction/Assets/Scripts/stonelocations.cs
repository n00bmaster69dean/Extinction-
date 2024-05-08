using UnityEngine;
using System.Collections;

public class stonelocations : MonoBehaviour {
	public Transform[] stonepositions;
	public GameObject stone;

	private int ranspawn;
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
	private bool pos16 = true;
	private bool pos17 = true;
	private bool pos18 = true;
	private bool pos19 = true;
	private bool pos20 = true;
	private bool pos21 = true;
	private bool pos22 = true;
	private bool pos23 = true;


	void Start () {
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();
		Stone ();



	}
	void Stone(){
		ranspawn = Random.Range (0, 23); 

		if (ranspawn == 0) {
			if (pos1 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos1 = false;
			} else if (pos1 == false) { 
				ranspawn += 1;
			}
		}
		if (ranspawn == 1) {
			if (pos2 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos2 = false;
			} else if (pos2 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 2) {
			if (pos3 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos3 = false;
			} else if (pos3 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 3) {
			if (pos4 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos4 = false;
			} else if (pos4 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 4) {
			if (pos5 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos5 = false;
			} else if (pos5 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 5) {
			if (pos6 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos6 = false;
			} else if (pos6 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 6) {
			if (pos7 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos7 = false;
			} else if (pos7 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 7) {
			if (pos8 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos8 = false;
			} else if (pos8 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 8) {
			if (pos9 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos9 = false;
			} else if (pos9 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 9) {
			if (pos10 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos10 = false;
			}
			 else if (pos10 == false) { 
				ranspawn += 1;
			}
		}
		
		if (ranspawn == 10) {
			if (pos11 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos11 = false;
			} else if (pos11 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 11) {
			if (pos12 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos12 = false;
			} else if (pos12 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 12) {
			if (pos13 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos13 = false;
			} else if (pos12 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 13) {
			if (pos14 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos14 = false;
			} else if (pos13 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 14) {
			if (pos15 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos15 = false;
			} else if (pos14 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 15) {
			if (pos16 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos16 = false;
			} else if (pos15 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 16) {
			if (pos17 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos17 = false;
			} else if (pos16 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 17) {
			if (pos18 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos18 = false;
			} else if (pos17 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 18) {
			if (pos19 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos19 = false;
			} else if (pos18 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 19) {
			if (pos20 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos20 = false;
			} else if (pos19 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 20) {
			if (pos21 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos21 = false;
			} else if (pos20 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 21) {
			if (pos22 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos22 = false;
			} else if (pos21 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 21) {
			if (pos22 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos22 = false;
			} else if (pos21 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 22) {
			if (pos23 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos23 = false;
			} else if (pos22 == false) { 
				ranspawn += 1;
			}
		}

		if (ranspawn == 23) {
			if (pos22 == true) {
				Instantiate (stone, (stonepositions [ranspawn].position), Quaternion.identity);
				pos22 = false;
			} else if (pos23 == false) { 
				ranspawn += 1;
			}
		}
	}
			
	void Update () {

	}}