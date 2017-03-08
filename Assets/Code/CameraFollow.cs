using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour //The Following Script Was Borrowed From http://answers.unity3d.com/questions/884006/camera-not-rotate-when-following-player.html
{
	public Transform Player;
	public Vector3 Offset;

	void LateUpdate()
	{
		if (Player != null)
			transform.position = Player.position + Offset; //This assigns the camera the position of that of the player plus a manually added offset.
	}


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
