using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour 
{
	public AudioClip paddleHitClip;
	public float paddHitVolume;

	public AudioClip brickHitClip;
	public float brickHitVolume;

	public AudioClip loseBoxClip;
	public float loseBoxVolume;

	public AudioClip wallHitClip;
	public float wallHitVolume;


	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void PlayPaddleHit()
	{
		AudioSource.PlayClipAtPoint (paddleHitClip,transform.position);
	}

	public void PlayBrickHit()
	{
		AudioSource.PlayClipAtPoint (brickHitClip,transform.position);
	}

	public void PlayLoseBox()
	{
		AudioSource.PlayClipAtPoint (loseBoxClip,transform.position);
	}

	public void PlayWallHit()
	{
		AudioSource.PlayClipAtPoint (wallHitClip,transform.position);
	}
}
