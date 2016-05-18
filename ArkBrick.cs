using UnityEngine;
using System.Collections;

public class ArkBrick : MonoBehaviour 
{
	public MusicManager musicManager;
	
	int brickDamageCount;
	
	public Sprite brokenBrickSprite;
	public SpriteRenderer brickSpriteRenderer;
	
	// Use this for initialization
	void Start () 
	{
		
		brickDamageCount = 0;
		GameManager.totalBrickCount++;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
	}
	
	void OnCollisionEnter2D()
	{
		musicManager.PlayBrickHit ();
		brickDamageCount++;
		
		if (brickDamageCount == 1) 
		{
			brickSpriteRenderer.sprite = brokenBrickSprite;
		}
		
		else if (brickDamageCount == 2) 
		{
			GameManager.totalBrickCount--;
			Destroy (gameObject);
			GameManager.score = GameManager.score + 250;
		}
		
		//Debug.Log ("collision");
		
		
		
	}
	
	void OnTriggerEnter2D()
	{
		Debug.Log ("Trigger");
		
		
	}
	
	
}
