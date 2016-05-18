using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public static int playerChances = 3;
	public static int totalBrickCount;
	public static int score;
	
	public int ballBoostLimit;
	
	public Text myScore;
	public Text myChancesleft;
	
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		myScore.text = score.ToString ();
		myChancesleft.text = "Chances Left  " + playerChances.ToString ();
		//Debug.Log (score);
		//Debug.Log (playerChances);
	}
}