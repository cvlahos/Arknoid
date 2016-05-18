using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{

	public bool noDetectionNeeded;

	void Update()
	{
		if (noDetectionNeeded == false) 
		{
			LoseGameDetector ();
			WinLevelDetector ();
		}
			
	

	}

	public void NextLevelToLoad()
	{
		Application.LoadLevel (Application.loadedLevel +1);
	}

	public void LoseGame()
	{
		Application.LoadLevel("Lose");


	}

	public void PlayGame()
	{

		GameManager.score = 0;
		GameManager.playerChances = 3;
		GameManager.totalBrickCount = 0;
		Application.LoadLevel("Game_01");

	}

	public void WinScreen()
	{
		Application.LoadLevel("Win");
	}

	public void QuitRequest()
	{
		Application.Quit ();
	}

	void WinLevelDetector()

	{
		if (GameManager.totalBrickCount == 0) 
		{
			NextLevelToLoad();
		}
	}

	void LoseGameDetector()
	{
		if (GameManager.playerChances == 0) 
		{
			LoseGame();
		}
	}


}
