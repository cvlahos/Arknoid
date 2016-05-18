using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour 
{
	public MusicManager musicManager;





	// Use this for initialization
	void Start () 
	{


		GameManager.totalBrickCount++;
	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}

	void OnCollisionEnter2D()
	{
		musicManager.PlayBrickHit ();
		GameManager.totalBrickCount--;
		Destroy (gameObject);
		GameManager.score = GameManager.score + 250;
	

		//Debug.Log ("collision");



	}
	
	void OnTriggerEnter2D()
	{
		Debug.Log ("Trigger");

		
	}


}
