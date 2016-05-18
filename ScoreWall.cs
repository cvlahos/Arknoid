using UnityEngine;
using System.Collections;


public class ScoreWall : MonoBehaviour 
{
	public int myPoints;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (myPoints == 3) 
		{
			Application.LoadLevel("Win");
		}

	}

	void OnTriggerEnter2D()
	{
		myPoints++;
		//Debug.Log (myPoints);
		//Application.LoadLevel("Lose");
	}

}
