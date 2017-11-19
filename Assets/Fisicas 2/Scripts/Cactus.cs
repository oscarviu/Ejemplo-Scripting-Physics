using UnityEngine;
using System.Collections;

public class Cactus : MonoBehaviour {
	public float outForce = 500;
	public float outTorque = 500;
	public float outForceUp = 60;

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("Colision");
		Vector3 vectorForce;

		vectorForce = collision.gameObject.transform.position - transform.position;

		collision.gameObject.GetComponent<Rigidbody>().AddForce((vectorForce) * outForce + Vector3.up * outForceUp);
		collision.gameObject.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.left * outTorque);
	}
}
