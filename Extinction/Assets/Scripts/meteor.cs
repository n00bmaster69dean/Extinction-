using UnityEngine;
using System.Collections;

public class meteor : MonoBehaviour {
	AudioSource snd;
	[SerializeField] AudioClip meteorsound;
	[SerializeField] AudioClip meteorsound2;
	[SerializeField] AudioClip meteorsound3;
	public GameObject coin;
	public GameObject snake;
	public GameObject spider;
	public GameObject hat;
	public GameObject explosions;
	public GameObject[] powerups;
	public Rigidbody2D meteorRB;
	public spawningmeteors spawning;

	private int ranchance;
	private int ran;
	private int rangameobject;
	private float ranchance2;



	// Use this for initialization
	void Start () {
		StartCoroutine (MyCoroutine ());
		snd = GetComponent<AudioSource> ();
		ranchance = Random.Range (0, 3);
		if (ranchance == 0){
			snd.PlayOneShot (meteorsound);
		}

		else if (ranchance == 1){
			snd.PlayOneShot (meteorsound2);
		}

		else if (ranchance == 2){
	
			snd.PlayOneShot (meteorsound3);
		}
		ranchance = Random.Range (0, 3);
		ranchance2 = Random.Range (150, 300);
		spawning = FindObjectOfType<spawningmeteors> ();
		meteorRB.AddForce (transform.up * (ranchance2 * -1));
		if (ranchance == 0) {
			if (spawning.frequent >= 3) {
				transform.localScale = new Vector3 (3.5f, 3.5f, 1f);
			}
		}
			
		if (spawning.frequent >= 5) {
		ran = Random.Range (0, 15);
		if (ran == 0) {
				ran = Random.Range (0, 15);
			if (ran == 0) {
					Instantiate (hat, new Vector2 (transform.position.x, transform.position.y),
						Quaternion.Euler (transform.rotation.x, transform.rotation.y, transform.rotation.z));
						}
	}
	}
	}

	void OnCollisionStay2D(Collision2D other){

		if (other.gameObject.tag == "enemy") {
			Destroy (other.gameObject);
		}
	}
		void OnTriggerStay2D(Collider2D other){

			if (other.gameObject.tag == "enemy") {
				Destroy (other.gameObject);
			}
	}

	void powerup(){
		rangameobject = Random.Range (0, 5);

		if (rangameobject == 0) {
			Instantiate (powerups[0], new Vector2 (transform.position.x, transform.position.y),
				Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z));
		}
		else if (rangameobject == 1) {
			Instantiate (powerups[1], new Vector2 (transform.position.x, transform.position.y),
				Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z));
		}
		else if (rangameobject == 2) {
			Instantiate (powerups[2], new Vector2 (transform.position.x, transform.position.y),
				Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z));
		}
		else if (rangameobject == 3) {
			Instantiate (powerups[3], new Vector2 (transform.position.x, transform.position.y),
				Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z));
		}

	}
	

	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == ("ground") || (other.tag == ("stone"))){
			Instantiate (coin, new Vector2 (transform.position.x, transform.position.y), Quaternion.Euler(transform.rotation.x, transform.rotation.y,transform.rotation.z));
			Destroy(other.gameObject);
			Instantiate (explosions, new Vector2 (transform.position.x, transform.position.y), Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z));
			Destroy (this.gameObject);
			ranchance = Random.Range (0, 7);
			if (ranchance == 0) {
				if (spawning.frequent >= 4) {
					powerup();
				}
				if (spawning.frequent >= 6) {
					powerup();
				}
				if (spawning.frequent >= 8) {
					powerup();
				}
			}
			if (spawning.frequent >= 4) {
				ran = Random.Range (0, 13);
				if (ran == 0) {
					Instantiate (snake, new Vector2 (transform.position.x, transform.position.y),
						Quaternion.Euler (transform.rotation.x, transform.rotation.y, transform.rotation.z));
				}
				if (ran == 1) {
					Instantiate (snake, new Vector2 (transform.position.x, transform.position.y),
						Quaternion.Euler (transform.rotation.x, transform.rotation.y, transform.rotation.z));
				}
				if (ran == 2) {
					Instantiate (spider, new Vector2 (transform.position.x, transform.position.y),
						Quaternion.Euler (transform.rotation.x, transform.rotation.y, transform.rotation.z));
				}
			}
		}
		}
	IEnumerator MyCoroutine(){
		yield return new WaitForSeconds (5);
		{
			Destroy (this.gameObject);
		}
	}
}
