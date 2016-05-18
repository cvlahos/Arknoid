using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{
	
	Rigidbody2D rb;
	public float ballSpeed;
	Vector2 reverseBallVelosity;
	public float boosterSpeed;
	
	public GameManager gameManager;
	
	public int boostCount;
	
	
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		reverseBallVelosity = -rb.velocity;
		//Debug.Log (boostCount);
		
	}
	
	public void LauchBall()
	{
		transform.parent = null;
		rb.velocity = new Vector2 (0,ballSpeed * Time.deltaTime);
		
	}
	
	
	void OnCollisionEnter2D()
	{
		if (boostCount < gameManager.ballBoostLimit) 
		{
			BoostSpeed ();
		}
		
		//Debug.Log ("ball collision");
		
	}
	
	void BoostSpeed()
	{
		boostCount++;
		rb.AddForce (reverseBallVelosity * boosterSpeed);
	}
	
}