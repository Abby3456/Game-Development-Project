using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCode : MonoBehaviour {

	public GameObject waterA;
	public GameObject waterB;
	public GameObject waterC;
	public GameObject waterD;

	public AudioClip Water;
	private AudioSource source;

	public GameObject particleThing;
	public ParticleSystem particles;
	public GameObject Player;

//	public bool facingRight = true;
//	public bool jump = false;
//	public float moveForce = 365f;
//	public float maxSpeed = 5f;
//	public float jumpForce = 1000f;
//	public Transform groundCheck;

//	private bool grounded = false;
//	private Rigidbody2D rb2d;

//	void Awake()
//	{
//		rb2d = GetComponent<Rigidbody2D> ();
//	}

	// Use this for initialization
//	void FixedUpdate () {

//		float h = Input.GetAxis ("Horizontal");
//		if (h * rb2d.velocity.x < maxSpeed)
//			rb2d.AddForce (Vector2.right * h * moveForce);

//		if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
//			rb2d.velocity = new Vector2 (Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

//		if (h > 0 && !facingRight)
//			Flip ();

//		if (jump) {
//			rb2d.AddForce (new Vector2 (0f, jumpForce));
//			jump = false;
//		}

//	}
	
	// Update is called once per frame
//	void Update () {
//		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Environment"));

//		if (Input.GetButtonDown ("Jump") && grounded || Input.GetKeyDown(KeyCode.W) && grounded) {
//			jump = true;
//		}

//	}

//	void Flip()
//	{
//		facingRight = !facingRight;
//		Vector3 theScale = transform.localScale;
//		theScale.x *= -1;
//		transform.localScale = theScale;
//	}

	public GameObject Enemy;

	//public bool shift;

	// Use this for initialization
	void Awake ()
	{
		source = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update ()
	{
		SpriteRenderer Player = GetComponent<SpriteRenderer> ();
		if (Input.GetKeyUp (KeyCode.Space) && Player.color == Color.blue) { 

			//SpriteRenderer Pan = GetComponent<SpriteRenderer>();
			Player.color = Color.red;
			Debug.Log ("This is also working");


		}
	}

	public void OnTriggerEnter2D (Collider2D otherCollider)
	{
		SpriteRenderer Player = GetComponent<SpriteRenderer> ();
		if (otherCollider.gameObject.tag == "Water") {
			//Player.color = Color.blue;
			Debug.Log ("This is working");

			Destroy (waterA.gameObject);

			GameObject newObject = Instantiate (particleThing) as GameObject;
			particles = newObject.GetComponent<ParticleSystem> ();

			source.PlayOneShot (Water, 1f);

		}

		if (otherCollider.gameObject.tag == "Water1") {
			//Player.color = Color.blue;
			Debug.Log ("This is working");

			Destroy (waterB.gameObject);

			GameObject newObject = Instantiate (particleThing) as GameObject;
			particles = newObject.GetComponent<ParticleSystem> ();
			source.PlayOneShot (Water, 1f);

		}

		if (otherCollider.gameObject.tag == "Water2") {
			//Player.color = Color.blue;
			Debug.Log ("This is working");

			Destroy (waterC.gameObject);

			GameObject newObject = Instantiate (particleThing) as GameObject;
			particles = newObject.GetComponent<ParticleSystem> ();
			source.PlayOneShot (Water, 1f);

		}

		if (otherCollider.gameObject.tag == "Water3") {
			//Player.color = Color.blue;
			Debug.Log ("This is working");

			Destroy (waterD.gameObject);

			GameObject newObject = Instantiate (particleThing) as GameObject;
			particles = newObject.GetComponent<ParticleSystem> ();
			source.PlayOneShot (Water, 1f);

		}
	}
}


	