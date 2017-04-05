using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {


	public GameObject Enemy;

	public GameObject Water;

	//public bool shift;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		SpriteRenderer Pan = GetComponent<SpriteRenderer> ();
		if (Input.GetKeyUp (KeyCode.Space) && Pan.color == Color.blue) { 

			//SpriteRenderer Pan = GetComponent<SpriteRenderer>();
			Pan.color = Color.red;
			Debug.Log ("This is also working");

		}
	}

	void OnTriggerEnter2D (Collider2D otherCollider)
	{
		SpriteRenderer Pan = GetComponent<SpriteRenderer> ();
		if (otherCollider.gameObject.tag == "Water") {
			Pan.color = Color.blue;
			Debug.Log ("This is working");
		}
	}
}
