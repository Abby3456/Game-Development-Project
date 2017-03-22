using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAction : MonoBehaviour {

	public ScoreCount1 score;

	public Transform player;
	public Vector3 Offset;

	//public Transform PlayerLoc;

	public Color color = new Color(84, 184, 255);

	public GameObject objectToSpawn;

	public GameObject[] Hearts;

	public bool freezeRotation;

	public RigidbodyConstraints constraints;

	public GameObject[] riceFriends;

	public GameObject particleThing;
	public ParticleSystem particles;
	public GameObject Player;

	public GameObject Pan;

	public AudioClip ASound;
	public AudioClip BSound;
	public AudioClip CSound;
	public AudioClip DSound;
	public AudioClip Damage;
	private AudioSource source;

	void Awake () {

		source = GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void Update()
	{

		particleThing.transform.position = Player.transform.position;

		if (particles != null) {

			if (!particles.IsAlive()) {

				Destroy (particles.gameObject);

			}

		}

		//if (Input.GetKeyDown(KeyCode.Escape))
		//{Application.LoadLevel("EndScene");}

		if (Input.GetKeyUp (KeyCode.UpArrow)) {



		}

		Rigidbody2D body = GetComponent<Rigidbody2D>();
		Vector2 currentVel = body.velocity;

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			GameObject newObject = Instantiate(objectToSpawn) as GameObject;
			SpriteRenderer objSprite = newObject.GetComponent<SpriteRenderer>();
			Vector3 newObjPos = newObject.transform.position + Offset;
			newObjPos.x = player.position.x;
			newObjPos.y = player.position.y;
			newObject.transform.position = newObjPos + Offset;

			score.riceSpent += 1;

			source.PlayOneShot (CSound, 1f);


		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			GameObject newObject = Instantiate(objectToSpawn) as GameObject;
			SpriteRenderer objSprite = newObject.GetComponent<SpriteRenderer>();
			Vector3 newObjPos = newObject.transform.position - Offset;
			newObjPos.x = player.position.x;
			newObjPos.y = player.position.y;
			newObject.transform.position = newObjPos - Offset;

			score.riceSpent += 1;

			source.PlayOneShot (CSound, 1f);

		}


	}
		

	public void GroupResize (int Size, ref GameObject[] Hearts) {
		GameObject[] heart = new GameObject[Size];
		for(int c = 1; c < Mathf.Min(Size, Hearts.Length); c++) {
			heart [c] = Hearts [c];

		}
		Hearts = heart;
	}

	public void BabyRiceUse(){

		objectToSpawn = riceFriends [0];
		source.PlayOneShot (ASound, 1f);

	}

	public void SlippyRiceUse(){
	
		objectToSpawn = riceFriends [1];
		source.PlayOneShot (BSound, 1f);

	}

	public void BouncyRiceUse(){

		objectToSpawn = riceFriends [2];
		source.PlayOneShot (DSound, 1f);

	}

	public void HeavyRiceUse(){

		objectToSpawn = riceFriends [3];
		source.PlayOneShot (CSound, 1f);

	}

	void OnTriggerEnter2D(Collider2D otherCollider){

		if (otherCollider.gameObject.tag == "Enemy") {
			GameObject newObject = Instantiate (particleThing) as GameObject;
			particles = newObject.GetComponent<ParticleSystem> ();

			source.PlayOneShot (Damage, 1f);
		}

	}

}
