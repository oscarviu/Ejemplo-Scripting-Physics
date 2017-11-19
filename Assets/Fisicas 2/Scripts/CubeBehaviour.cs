using UnityEngine;
using System.Collections;

public class CubeBehaviour : MonoBehaviour
{
	public float translationSpeed = 1f;
	public float rotationSpeed = 360f;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.forward * translationSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.S))
			transform.Translate(-Vector3.forward * translationSpeed * Time.deltaTime);
	
		if(Input.GetKey(KeyCode.A))
			transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.D))
			transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
	
	}
	
}
