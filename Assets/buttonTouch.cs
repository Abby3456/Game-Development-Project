using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonTouch : MonoBehaviour {

	public bool touched;
	public GameObject water;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (touched == true) {
			water.GetComponent<SpriteRenderer> ().enabled = true;
			water.GetComponent<CircleCollider2D> ().enabled = true;
		}
		
	}

	void OnTriggerStay2D(Collider2D other){

		Debug.Log ("hey");

		if (other.gameObject.GetComponent<SpriteRenderer>().name == "HeavyRice_0" || 
			other.gameObject.GetComponent<SpriteRenderer>().name == "HeavyRice_1") {
			
			touched = true;
		}


	}

	void OnTriggerExit2D(Collider2D other){

		if (other.gameObject.name == "angryrice") {
			touched = false;
		}

	}


}
