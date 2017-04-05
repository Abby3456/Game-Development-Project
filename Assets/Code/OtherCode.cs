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
			
			Player.color = Color.red;
			Debug.Log ("This is also working");


		}
	}

	public void OnTriggerEnter2D (Collider2D otherCollider)
	{
		SpriteRenderer Player = GetComponent<SpriteRenderer> ();
		if (otherCollider.gameObject.tag == "Water") {
			Debug.Log ("This is working");

			Destroy (waterA.gameObject);

			GameObject newObject = Instantiate (particleThing) as GameObject;
			particles = newObject.GetComponent<ParticleSystem> ();

			source.PlayOneShot (Water, 1f);

		}

		if (otherCollider.gameObject.tag == "Water1") {
			Debug.Log ("This is working");

			Destroy (waterB.gameObject);

			GameObject newObject = Instantiate (particleThing) as GameObject;
			particles = newObject.GetComponent<ParticleSystem> ();
			source.PlayOneShot (Water, 1f);

		}

		if (otherCollider.gameObject.tag == "Water2") {
			Debug.Log ("This is working");

			Destroy (waterC.gameObject);

			GameObject newObject = Instantiate (particleThing) as GameObject;
			particles = newObject.GetComponent<ParticleSystem> ();
			source.PlayOneShot (Water, 1f);

		}

		if (otherCollider.gameObject.tag == "Water3") {
			Debug.Log ("This is working");

			Destroy (waterD.gameObject);

			GameObject newObject = Instantiate (particleThing) as GameObject;
			particles = newObject.GetComponent<ParticleSystem> ();
			source.PlayOneShot (Water, 1f);

		}
	}
}


	