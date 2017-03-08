using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles1 : MonoBehaviour {

	public GameObject particleThing;
	public ParticleSystem particles;
	public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		particleThing.transform.position = Player.transform.position;

		if (particles != null) {

			if (!particles.IsAlive()) {

				Destroy (particles.gameObject);

			}

		}

	}

	public void SpawnParticle(){

		GameObject newObject = Instantiate(particleThing) as GameObject;
		particles = newObject.GetComponent<ParticleSystem>();

	}
}
