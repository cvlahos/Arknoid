using UnityEngine;
using System.Collections;

public class Clamp : MonoBehaviour 
{
	public float sphereSpeed;
	public float leftBounds;
	public float rightBounds;

	
	//Vector3 spherePosition;
	
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () 
	{

		transform.position = new Vector3 (Mathf.Clamp (transform.position.x,leftBounds,rightBounds),0,0);	

		if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			transform.position += new Vector3 (-sphereSpeed * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey(KeyCode.RightArrow)) 
		{
			transform.position += new Vector3 (sphereSpeed * Time.deltaTime, 0, 0);
		}


	}
}
