using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBehaviour : MonoBehaviour
{
    // Simplemente indica a la esfera si está tocando el suelo
    private void OnCollisionEnter(Collision collision)
    {
        sphereBehaviour sphere = collision.gameObject.GetComponent<sphereBehaviour>();
        if (sphere)
            sphere.onFloor = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        sphereBehaviour sphere = collision.gameObject.GetComponent<sphereBehaviour>();
        if (sphere)
            sphere.onFloor = false;
    }

    // Para realizar la comunicación entre gameobjects podemos usar 
    // tambien el sistema de mensajes, permitiendo desacoplar las clases.
    // https://docs.unity3d.com/Manual/MessagingSystem.html

    private void OnCollisionStay(Collision collision)
    {
        // la esfera rodará hacia el eje 'z' global
        //collision.gameObject.GetComponent<Rigidbody>().AddTorque(Vector3.right * 2);
        //Debug.Log(Time.deltaTime);
    }

}
