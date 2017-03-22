using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCount1 : MonoBehaviour {

	public int riceSpent;

	public float score;

	public Text countText;
	public Text numberText;
	public Text winText;


	// Use this for initialization
	void Start () {
		Debug.Log ("Hi");

		winText.text = "";

		SetCountText ();

	}

	// Update is called once per frame
	void Update () {

		score = 1000f - (riceSpent * 5);

		SetCountText ();

	///	if (score = 0) {

	///		Application.LoadLevel("QuitScene");

	///	}

	}

	void SetCountText(){

		countText.text = "Score: " + score;
		numberText.text = "Rice Spent: " + riceSpent;

		if (score >= 1001) {

			winText.text = "PERFECT";

		}

		if (score <= 1) {

			winText.text = " ";

		}

	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.tag == "Enemy") {
			riceSpent = riceSpent + 10;
		}

		if (otherCollider.gameObject.tag == "Water") {
			riceSpent = riceSpent - 50;
		}
	}
		
}
