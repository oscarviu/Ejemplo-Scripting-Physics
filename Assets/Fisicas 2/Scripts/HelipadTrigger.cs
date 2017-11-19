using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelipadTrigger : MonoBehaviour
{
	public float force = 1f;

	private void OnTriggerEnter(Collider other)
	{
		// Se ejecuta al acceder a la zona
	}

	private void OnTriggerExit(Collider other)
	{
		// Se ejecuta al salir de la zona
	}

	private void OnTriggerStay(Collider other)
	{
		other.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
	}
}
