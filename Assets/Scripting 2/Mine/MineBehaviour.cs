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

	// Update is called once per frame
	void Update ()
	{
		if((GameObject.Find("Tank").transform.position - transform.position).magnitude < 2 && activate)
		{
			disappearing = true;
		}

		if(disappearing)
		{
			if (currentTime > secondsBetweenDisappearing)
			{
				gameObject.GetComponent<Renderer>().enabled = !gameObject.GetComponent<Renderer>().enabled;
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
