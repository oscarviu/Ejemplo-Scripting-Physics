using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviourP : MonoBehaviour
{
    public float amount = 50f;
    Rigidbody rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;

        rigid.AddForce(Vector3.right * h);
        rigid.AddForce(Vector3.forward * v);
    }
}
