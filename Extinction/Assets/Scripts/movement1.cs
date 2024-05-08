using UnityEngine;
using System.Collections;

public class movement1 : MonoBehaviour {

	AudioSource snd;
	[SerializeField] AudioClip footsteeps;
	[SerializeField] AudioClip jumpsound;
	[SerializeField] AudioClip coin;
	Animator an;
	public bool hat = true;
	private float speed = 0.8f;
	private float jump = 6;
	private bool check = true;
	private bool held = false;
	public bool space = false;
	private bool wait = false;
	private bool wait2 = false;
	private bool wait3 = false;
	private bool powerupaxe = false;
	private bool powerupshild = false;
	public Rigidbody2D playerRB;
	public spawningmeteors spawning;
	public Rigidbody2D enemyRB;

	[SerializeField] Transform groundcheck;
	[SerializeField] float groundcheckraidius;
	[SerializeField] LayerMask ground;
	[SerializeField] private bool grounded;

	private float direction;

	void Start () {
		spawning = FindObjectOfType<spawningmeteors> ();
		snd = GetComponent<AudioSource> ();
		an = GetComponent<Animator>();
		an.SetInteger ("animationstate", 0);
		if (grounded == true){
			if (hat == true){
				an.SetInteger ("animationstate", 0);
			}
			else if (hat == false){
				an.SetInteger ("animationstate", 5);
			}
		}
	}

	void FixedUpdate(){

		grounded = Physics2D.OverlapCircle (groundcheck.position, groundcheckraidius, ground);
		if (grounded == false) {
			if (hat == true){
				an.SetInteger ("animationstate", 2);
			}
			else if (hat == false){
				an.SetInteger ("animationstate", 6);
			}
		}
	}

	void Update () {
		//print (hat);
		
		if (Input.GetKeyDown ("up") && grounded) {
			playerRB.velocity = new Vector2 (playerRB.velocity.x, jump);
			if (hat == true){
				an.SetInteger ("animationstate", 2);
			}
			else if (hat == false){
				an.SetInteger ("animationstate", 6);
			}
			snd.PlayOneShot (jumpsound);
		}

		if (Input.GetKey ("left")) {

			transform.localScale = new Vector3 (-3f, 3f, 3f);
		}
		if (Input.GetKey ("right")) {
			
			transform.localScale = new Vector3 (3f, 3f, 3f);
		}
					

		if (Input.GetKey ("left")) {
			playerRB.velocity = new Vector2 (-speed + playerRB.velocity.x, playerRB.velocity.y);
			Vector3 clampvel = playerRB.velocity;
			clampvel.x = Mathf.Clamp (clampvel.x, -5, 0);
			playerRB.velocity = clampvel;
			if (!snd.isPlaying && grounded) {
				snd.PlayOneShot (footsteeps);
			}
		}

		if (Input.GetKey ("right")) {
			playerRB.velocity = new Vector2 (speed + playerRB.velocity.x, playerRB.velocity.y);
			Vector3 clampvel = playerRB.velocity;
			clampvel.x = Mathf.Clamp (clampvel.x, 0, 5);
			playerRB.velocity = clampvel;

			if (!snd.isPlaying && grounded) {
				snd.PlayOneShot (footsteeps);
			}
		}

		if (Input.GetKey ("right") && grounded == true) {
			if (hat == true){
				an.SetInteger ("animationstate", 1);
			}
			else if (hat == false){
				an.SetInteger ("animationstate", 7);
			}
		}

		if (Input.GetKey ("left") && grounded == true) {
			if (hat == true){
				an.SetInteger ("animationstate", 1);
			}
			else if (hat == false){
				an.SetInteger ("animationstate", 7);
			}
		}
			

		if ((grounded == true) && Input.GetKeyDown ("space")) {
			space = true;
			}

		if ((grounded == true) && Input.GetKeyUp ("space")) {
			if (hat == true){
				an.SetInteger ("animationstate", 0);
			}
			else if (hat == false){
				an.SetInteger ("animationstate", 5);
			}
			space = false;
			held = false;
		}

		if ((grounded == true) && Input.GetKey ("space")) {
			if (hat == true){
				an.SetInteger ("animationstate", 3);
			}
			else if (hat == false){
				an.SetInteger ("animationstate", 8);
			}
			playerRB.velocity = new Vector2 (0, playerRB.velocity.y);
		}

		if(Input.GetKey ("right") && (Input.GetKey ("up"))){
			if (hat == true){
				an.SetInteger ("animationstate", 2);
			}
			else if (hat == false){
				an.SetInteger ("animationstate", 6);
			}
		}

		if(Input.GetKey ("left") && (Input.GetKey ("up"))){
			if (hat == true){
				an.SetInteger ("animationstate", 2);
			}
			else if (hat == false){
				an.SetInteger ("animationstate", 6);
			}
		}

		if (Input.GetKeyUp ("right")) {
			//playerRB.velocity = new Vector2 ((speed + playerRB.velocity.x)%6, playerRB.velocity.y);
			playerRB.velocity = new Vector2 (0, playerRB.velocity.y);
		}

		if (Input.GetKeyUp ("left")) {
			//playerRB.velocity = new Vector2 ((-speed + playerRB.velocity.x)%6, playerRB.velocity.y);
			playerRB.velocity = new Vector2 (0, playerRB.velocity.y);
		}

		if ((Input.anyKey == false) && (grounded == true)){
			if (hat == true){
				an.SetInteger ("animationstate", 0);
			}
			else if (hat == false){
				an.SetInteger ("animationstate", 5);
			}
		}
	}

	IEnumerator OnTriggerStay2D(Collider2D other){
		
		if (other.gameObject.tag == "meteor") {
			if (powerupshild == false) {

				if (hat == false) {
					Time.timeScale = 0.1f;
					//Application.LoadLevel ("scene");
				} else if (hat == true) {
					hat = false;
					an.SetInteger ("animationstate", 5);

				}
			}
				}
		
		if ((grounded == true) && (space == true) && (other.tag == "ground")) {
			if (check == true) {
				held = true;
				check = false;
				StartCoroutine (MyCoroutine ());
				if (wait == true) {
					wait = false;
					Destroy (other.gameObject);
			
				}
			}
		}

		if (other.gameObject.tag == "enemy") {
			if ((grounded == true) && Input.GetKey ("space")) {
				StartCoroutine (MyCoroutine3 ());
				if (wait3 == true) {
					Destroy (other.gameObject);
					wait3 = false;
				}
			}
		}
			
		if (other.tag == "coin") {
			snd.PlayOneShot (coin);
			spawningmeteors.score += 1;
			Destroy (other.gameObject);
			}


		if ((grounded == true) && (space == true) && (other.tag == "stone")){
			StartCoroutine (MyCoroutine2 ());
			if (wait2 == true) {
				Destroy (other.gameObject);
				wait2 = false;
			}
		}

		if (other.gameObject.tag == "enemy") {
			if (grounded == false) {
				other.transform.localScale = new Vector3 (other.transform.localScale.x, 2f, other.transform.localScale.z);
				yield return new WaitForSeconds (0.54f);
				Destroy (other.gameObject);
				}
			}
	}

	void OnCollisionStay2D(Collision2D other){

		if (other.gameObject.tag == "hat") {
			if (hat == false){
			hat = true;
			an.SetInteger ("animationstate", 0);
			Destroy (other.gameObject);
			}
		}

		if (other.gameObject.tag == "prun") {
			speed = 2f;
			jump = 5;

			powerupaxe = false;
			powerupshild = false;
			StartCoroutine (MyCoroutine4 ());
			Destroy (other.gameObject);
				}
		if (other.gameObject.tag == "paxe") {
			speed = 0.8f;
			jump = 5;
			powerupaxe = true;
			powerupshild = false;
			StartCoroutine (MyCoroutine4 ());
			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "pjump") {
			jump = 8f;
			speed = 0.8f;
			powerupaxe = false;
		
			powerupshild = false;
			StartCoroutine (MyCoroutine4 ());
			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "psheild") {
			speed = 0.8f;
			jump = 5;
			powerupshild = true;
			powerupaxe = false;
			StartCoroutine (MyCoroutine4 ());
			Destroy (other.gameObject);
		}
	}

	IEnumerator MyCoroutine(){
		if (powerupaxe == false){
			yield return new WaitForSeconds (0.5f);
		}
		{
			if ((grounded == true) && Input.GetKey ("space")){
				if (held == true) {
					wait = true;
				}
			}
			check = true;

		}
	}
	IEnumerator MyCoroutine2(){
		if (powerupaxe == false){
			yield return new WaitForSeconds (1.3f);
		}
		{
			if ((grounded == true) && Input.GetKey ("space")){
				wait2 = true;
			}
		}
	}

	IEnumerator MyCoroutine3(){
		yield return new WaitForSeconds (0.14f);
		{
			if ((grounded == true) && Input.GetKey ("space")){
				wait3 = true;
			}
		}
	}
	IEnumerator MyCoroutine4(){
		yield return new WaitForSeconds (10f);
		{
			
			powerupaxe = false;
			powerupshild = false;
		}
	}
}
