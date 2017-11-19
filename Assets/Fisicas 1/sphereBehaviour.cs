using UnityEngine;
using System.Collections;

public class sphereBehaviour : MonoBehaviour
{

	public float amount = 50f;
	Rigidbody rigid;
	
	void FixedUpdate()
	{
		float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
		float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;

		rigid.AddTorque(Vector3.back * h);
		rigid.AddTorque(Vector3.right * v);
	}

	void Awake()
	{
		rigid = GetComponent<Rigidbody>();
	}
}
