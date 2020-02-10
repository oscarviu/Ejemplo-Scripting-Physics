using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBehaviour : MonoBehaviour
{
	const float timeToActivate = 2f;
	const float secondsBetweenDisappearing = 0.2f;

	bool activate = false;
	bool disappearing = false;
	float currentTime = 0;

    [SerializeField]
    protected GameObject tankObject = null;

    void Start()
    {
        if (tankObject == null)
            tankObject = GameObject.Find("Tank");

    }

    // Update is called once per frame
    void Update ()
	{
		if((tankObject.transform.position - transform.position).sqrMagnitude < 4 && activate)   // 2 units
		{
			disappearing = true;
		}

		if(disappearing)
		{
			if (currentTime > secondsBetweenDisappearing)
			{
				GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
				currentTime = 0;
			}
		}
		else if(currentTime >= timeToActivate)
		{
			// start disappearing
			GetComponent<Renderer>().material.color = Color.green;
			currentTime = 0;
			activate = true;
			
		}
		currentTime += Time.deltaTime;
	}
}
