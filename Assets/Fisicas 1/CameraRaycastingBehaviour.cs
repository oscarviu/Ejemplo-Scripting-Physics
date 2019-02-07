using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycastingBehaviour : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray  = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        
        if(Input.GetMouseButtonDown(0))
            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                Debug.Log("Clic sobre " + objectHit.name);
                // Do something with the object that was hit by the raycast.
                Rigidbody rigid = objectHit.GetComponent<Rigidbody>();
                if(rigid)
                    rigid.AddForce(Vector3.up *2 + transform.up, ForceMode.Impulse);
            }
    }
}