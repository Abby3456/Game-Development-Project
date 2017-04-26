using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RevisedScoreCound : MonoBehaviour {

	public int riceSpent;

	public GameObject other1;
	public GameObject other2;
	public GameObject other3;
	public GameObject otherA;
	public GameObject otherB;
	public GameObject otherC;

	public float score;

	public Text countText;
	public Text numberText;
	//public Text winText;

	public GameObject[] waterCount;


	// Use this for initialization
	void Start () {
		Debug.Log ("Hi");

	//	winText.text = "";

		SetCountText ();

	}

	// Update is called once per frame
	void Update () {

		score = 250f - (riceSpent);

		SetCountText ();

		///	if (score = 0) {

		///		Application.LoadLevel("QuitScene");

		///	}

		if (score <= 0) {
			SceneManager.LoadScene ("Lose");
		}
	}

	void SetCountText(){

		countText.text = "Rice Remaining: " + score;
		numberText.text = "";

		/*if (score >= 2000) {

			winText.text = "PERFECT";

		}

		if (score <= 1) {

			winText.text = " ";

		}*/

	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		//if (otherCollider.gameObject.tag == "Enemy") {
		//	riceSpent = riceSpent + 10;
		//}

		if (otherCollider.gameObject.tag == "Enemy") {
			riceSpent = riceSpent + 10;
		}

		if (otherCollider.gameObject.tag == "Water") {
			riceSpent = riceSpent - 10;
			SceneManager.LoadScene ("Win");
		}
		if (otherCollider.gameObject.tag == "Water1") {
			riceSpent = riceSpent - 10;
			Destroy(otherB.gameObject);
			Destroy(other2.gameObject);
		}
		if (otherCollider.gameObject.tag == "Water2") {
			riceSpent = riceSpent - 10;
			Destroy(otherC.gameObject);
			Destroy(other3.gameObject);
		}
		if (otherCollider.gameObject.tag == "Water3") {
			riceSpent = riceSpent - 10;
			Destroy(otherA.gameObject);
			Destroy(other1.gameObject);
		}
	}

	void OnTriggerStay2D(Collider2D otherCollider){


	}
}