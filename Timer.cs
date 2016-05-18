using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{
	public float timer;
	public LevelManager levelManager;
	Text myTimer;
	// Use this for initialization
	void Start()
	{
		myTimer = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		myTimer.text = timer.ToString ();

		//timer = timer - Time.deltaTime;
		timer -= Time.deltaTime;

		if (timer <= 0f) 
		{
			levelManager.LoseGame();
		}



	}
}
