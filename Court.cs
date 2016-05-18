using UnityEngine;
using System.Collections;

public class Court : MonoBehaviour 
{
	public MusicManager musicManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D()
	{
		musicManager.PlayWallHit ();
		//Debug.Log ("Paddle collision");
	}


}
