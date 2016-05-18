using UnityEngine;
using System.Collections;

public class Vector : MonoBehaviour 
{
	public float sphereSpeed;

	//Vector3 spherePosition;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () 
	{

		//spherePosition = new Vector3 (-1, 0, 0);

		//transform.position += spherePosition;

		transform.position += new Vector3 (sphereSpeed * Time.deltaTime, 0, 0);
	}
}
