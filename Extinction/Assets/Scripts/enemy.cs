using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	Animator an;
	public movement1 player;
	public Rigidbody2D enemyRB;
	public GameObject spits;
	public GameObject enemys;
	public float speed = 1f;
	public Transform enemysightstart, enemysightend;
	[SerializeField] private bool spotted = false;
	private bool wall = false;
	private bool ground = false;
	private bool reload = false;
	private int trap;
	[SerializeField] private bool wait = true;

	void Start () {
		DontDestroyOnLoad(gameObject);
		player = FindObjectOfType<movement1> ();
		an = GetComponent<Animator>();
		an.SetInteger ("animationstate", 0);
	}

	void Update () {
		
		Raycast ();

		if (spotted == false) {
			enemyRB.velocity = new Vector2 (speed, enemyRB.velocity.y);
		}

		if ((wall == true) || (ground == true)) {
			trap = Random.Range (0, 9); 
			if (trap == 0) {
				if (reload == false) {
					Instantiate (spits, new Vector2 (transform.position.x, transform.position.y), Quaternion.Euler (transform.rotation.x, transform.rotation.y, transform.rotation.z));
					reload = true;
					StartCoroutine (MyCoroutine2 ());
				}
			}
			transform.localScale = new Vector3 (transform.localScale.x * -1f, transform.localScale.y, transform.localScale.z);
			speed = speed * -1;
		}
		if (spotted == true) {
			if (wait == true){
				StartCoroutine (MyCoroutine ());
				wait = false;
			}
		}

		if (spotted == false) {
			an.SetInteger ("animationstate", 0);
		}
	}

	void Raycast(){
		Debug.DrawLine(enemysightstart.position, enemysightend.position, Color.green);
		spotted = Physics2D.Linecast (enemysightstart.position, enemysightend.position, 1 << LayerMask.NameToLayer("player"));
		wall = Physics2D.Linecast (enemysightstart.position, enemysightend.position, (1 << LayerMask.NameToLayer("wall")));
		ground = Physics2D.Linecast (enemysightstart.position, enemysightend.position, (1 << LayerMask.NameToLayer("ground")));
			} 

	IEnumerator MyCoroutine (){
		yield return new WaitForSeconds (0.5f);
		an.SetInteger ("animationstate", 1);
		Instantiate (spits, new Vector2 (transform.position.x, transform.position.y), Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z));
		enemyRB.velocity = new Vector2 (0, 0);
		yield return new WaitForSeconds (1f);
		wait = true;
	}

	IEnumerator MyCoroutine2 (){
		yield return new WaitForSeconds (1f);
		if (reload == true){
			reload = false;
		}
	}
}

