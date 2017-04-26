using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCodeA : MonoBehaviour {

	public GameObject particleA;
	public ParticleSystem particlesA;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {
			GameObject newObject = Instantiate (particleA) as GameObject;
			particlesA = newObject.GetComponent<ParticleSystem> ();
		}
	
		if (particlesA != null) {

			if (!particlesA.IsAlive()) {

				Destroy (particlesA.gameObject);
			}
		}
	}
}
