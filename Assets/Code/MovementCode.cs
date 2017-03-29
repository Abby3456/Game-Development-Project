using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCode : MonoBehaviour {

	[HideInInspector] public bool facingRight = true; //unity3d.com Creating a Simple Platformer Game, Simple Platformer Controller
	[HideInInspector] public bool jump = false;
	public float moveForce = 365f;
	public float maxSpeed = 5f;
	public float jumpForce = 1000f;


	public AudioClip jumpSound;
	private AudioSource source;

	private bool grounded = false;
	public Transform groundCheck;

	private bool damaged = false;

	private Rigidbody2D rb2d;

	bool facingLeft = true;

	Animator anim;

	void Awake () {

		rb2d = GetComponent<Rigidbody2D> ();

		source = GetComponent<AudioSource> ();

	}

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		anim.SetBool ("Damaged", damaged);
	}
	
	// Update is called once per frame
	void Update () {

		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Environment"));

		if (Input.GetButtonDown ("Jump") && grounded) {

			anim.SetBool ("Ground", false);
			jump = true;

			source.PlayOneShot (jumpSound, 1f);

		}

	}

	void FixedUpdate(){

		anim.SetBool ("Ground", grounded);
		anim.SetFloat ("vSpeed", rb2d.velocity.y);

		float h = Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (h));

		if (h * rb2d.velocity.x < maxSpeed) {

			rb2d.AddForce (Vector2.right * h * moveForce);

		}

		if (Mathf.Abs (rb2d.velocity.x) > maxSpeed) {

			rb2d.velocity = new Vector2 (Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

		}

		if(jump){

			rb2d.AddForce (new Vector2 (0f, jumpForce));
			jump = false;

		}

		if (h < 0 && !facingLeft)
			Flip ();
		else if (h > 0 && facingLeft)
			Flip ();


	}

	void Flip(){
		facingLeft = !facingLeft;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void OnTriggerEnter2D(Collider2D otherCollider){

		if (otherCollider.gameObject.tag == "Enemy") {

			anim.SetBool ("Damaged", true);
		
		} else {
			anim.SetBool ("Damaged", false);
		}

	}

}


