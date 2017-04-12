using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appearScript : MonoBehaviour {

	public GameObject button;
	public buttonTouch buttonTouch;

	// Use this for initialization
	void Start () {
		
		buttonTouch = (buttonTouch)button.GetComponent (typeof(buttonTouch));

	}
	
	// Update is called once per frame
	void Update () {


		if (buttonTouch.touched == true) {
			this.GetComponent<SpriteRenderer> ().enabled = true;
			this.GetComponent<CircleCollider2D> ().enabled = true;
		}


	}
}
