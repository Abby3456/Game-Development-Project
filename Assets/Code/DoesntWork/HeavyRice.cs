using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyRice : MonoBehaviour {

	//THIS CODE JUST DIDN'T WORK

	public static HeavyRice Instance;


	public AnimationCurve shakeCurve;
	public float shakeTime = 1.0f;
	float timer;

	public GameObject Button;
	public GameObject Door;

	public enum ShakeTypes
	{
		horizontal,
		vertical,
		all}

	;

	public ShakeTypes currentShake;

	bool verticalShake, horizontalShake, allShake;

	void Start()
	{
		Instance = this;
		timer = shakeTime;
	}


	void LateUpdate()
	{ 
		if (timer < shakeTime)
		{
			float shakeAmt = shakeCurve.Evaluate(timer); 
			//use the curve to animate the shake amount
			float rnd = Random.Range(-shakeAmt, shakeAmt);


			//randomize the position, using the shake amount
			if (currentShake == ShakeTypes.vertical)
			{

				Camera.main.transform.localPosition += new Vector3(0, rnd, 0);
			}
			else if (currentShake == ShakeTypes.horizontal)
			{
				Camera.main.transform.localPosition += new Vector3(rnd, 0, 0);
			}
			else if (currentShake == ShakeTypes.all)
			{
				Camera.main.transform.localPosition += new Vector3(rnd, rnd, 0);
			}

			timer += Time.deltaTime;
		}
	}

	public void BeginShake(ShakeTypes shake)
	{

		this.currentShake = shake;

		if (timer >= shakeTime)
		{
			timer = 0; 
		}

	}

	/*public void OnTriggerEnter2D(Collider2D otherCollider){
		if (otherCollider.gameObject.tag == "Button") {
			Debug.Log ("Work");
			Destroy (Door.gameObject);


		}
	}*/

}
