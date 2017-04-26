using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadStage(){
		Application.LoadLevel ("TestScene2");
	}

	public void LoadControls(){
		Application.LoadLevel ("Controls");
	}

	public void LoadLore(){
		Application.LoadLevel ("Story");
	}

	public void LoadMenu(){
		Application.LoadLevel ("StartMenu");
	}

	public void LoadSandbox(){
		Application.LoadLevel ("Sandbox");
	}
}
