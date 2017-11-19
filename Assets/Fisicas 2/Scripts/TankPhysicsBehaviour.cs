using UnityEngine;
using System.Collections;

public class TankPhysicsBehaviour : MonoBehaviour
{
	public float acceleration = 20f;
	public float turnAcceleration = 2f;

	float currentRotation = 0;

	// Use this for initialization
	void Start ()
	{

		Debug.Log("Tanque arrancado");
		transform.localPosition = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		// Movement
		if (Input.GetKey(KeyCode.UpArrow))
			GetComponent<Rigidbody>().AddForce(transform.forward * acceleration, ForceMode.Acceleration);
		else if (Input.GetKey(KeyCode.DownArrow))
			GetComponent<Rigidbody>().AddForce(-transform.forward * acceleration, ForceMode.Acceleration);
		
		
		// Rotation
		if (Input.GetKey(KeyCode.LeftArrow))
			GetComponent<Rigidbody>().AddTorque(-transform.up * turnAcceleration);
		else if (Input.GetKey(KeyCode.RightArrow))
			GetComponent<Rigidbody>().AddTorque(transform.up * turnAcceleration);


		// Reset
		if (Input.GetKey(KeyCode.R))
		{

			GetComponent<Rigidbody>().MovePosition(Vector3.up * 5);
			GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(Vector3.zero));
			GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
			GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
			/*
			// Rotation
			if (Input.GetKey(KeyCode.LeftArrow))
				currentRotation -= turnAcceleration * Time.deltaTime;
			else if (Input.GetKey(KeyCode.RightArrow))
				currentRotation += turnAcceleration * Time.deltaTime;
			GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(0f, currentRotation, 0f));
			*/


		}
}
