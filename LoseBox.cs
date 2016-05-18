using UnityEngine;
using System.Collections;

public class LoseBox : MonoBehaviour 
{
	public Rigidbody2D ballRB;
	public Transform ballTR;
	public Transform paddleTR;
	
	public MusicManager musicManager;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter2D()
	{
		//Debug.Log ("collision");
	}
	
	void OnTriggerEnter2D()
	{
		//Debug.Log ("Trigger");
		musicManager.PlayLoseBox ();
		ResetBall ();

	}

	void ResetBall()
	{
		ballRB.velocity = new Vector2 (0,0);
		ballTR.parent = paddleTR;
		ballTR.position = new Vector2 (paddleTR.position.x,paddleTR.position.y + .5f);
		Paddle.isBallLaunched = false;
		GameManager.playerChances--;
	}
}
