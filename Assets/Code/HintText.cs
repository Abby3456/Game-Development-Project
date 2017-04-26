using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HintText : MonoBehaviour {

	public Text hintText;

	// Use this for initialization
	void Start () {
		hintText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void regularHint(){
		hintText.text = "He doesn't do much, but that makes him the easist to use.";
	}

	public void slippyHint(){
		hintText.text = "Difficult, but useful in tight spaces.";
	}

	public void bouncyHint(){
		hintText.text = "A child of pure chaos. Best choice for launching.";
	}

	public void heavyHint(){
		hintText.text = "Not the cheeriest, but the only one capable of pushing buttons.";
	}
}
