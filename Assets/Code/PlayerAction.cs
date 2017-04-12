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
	public AudioClip soundToPlay;

	public bool freezeRotation;

	public RigidbodyConstraints constraints;

	public GameObject[] riceFriends;

	public GameObject particleThing;
	public ParticleSystem particles;
	public GameObject Player;

	public GameObject Pan;

	public AudioClip[] pressSounds;

	public AudioClip ASound;
	public AudioClip BSound;
	public AudioClip CSound;
	public AudioClip DSound;
	public AudioClip Damage;
	private AudioSource source;

	void Awake () {

		source = GetComponent<AudioSource> ();
		objectToSpawn = riceFriends [0];
		soundToPlay = pressSounds [0];

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

			source.PlayOneShot (soundToPlay, 1f);

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

			source.PlayOneShot (soundToPlay, 1f);


		}

	}
		

	public void BabyRiceUseAwake(){
		
		objectToSpawn = riceFriends [0];
		soundToPlay = pressSounds [0];
		//source.PlayOneShot (ASound, 1f);

	}

	public void BabyRiceUse(){

		objectToSpawn = riceFriends [0];
		soundToPlay = pressSounds [0];
		source.PlayOneShot (ASound, 1f);

	}

	public void SlippyRiceUse(){
	
		objectToSpawn = riceFriends [1];
		soundToPlay = pressSounds [1];
		source.PlayOneShot (BSound, 1f);

	}

	public void BouncyRiceUse(){

		objectToSpawn = riceFriends [2];
		soundToPlay = pressSounds [3];
		source.PlayOneShot (DSound, 1f);

	}

	public void HeavyRiceUse(){

		objectToSpawn = riceFriends [3];
		soundToPlay = pressSounds [2];
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
