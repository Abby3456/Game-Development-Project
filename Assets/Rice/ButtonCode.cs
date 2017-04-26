using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCode : MonoBehaviour {

	public GameObject Button;
	public GameObject Door;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D otherCollider){
		if (otherCollider.gameObject.tag == "Button") {
			Destroy(Door.gameObject);


		}
	}
}
