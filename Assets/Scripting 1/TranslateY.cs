using UnityEngine;
using System.Collections;

public class TranslateY : MonoBehaviour
{
	public float speed = 1;

	float posY = 0;
	bool up = false;

	const float MAX = 0;
	const float MIN = -2;


	// Update is called once per frame
	void Update ()
	{
		if(up)
		{
			posY += Time.deltaTime * speed;
		}
		else
		{
			posY -= Time.deltaTime * speed;
		}

		if(posY >= MAX)
			up = false;
		else if(posY <= MIN)
			up = true;
		 
		transform.localPosition = new Vector3(0,posY,0);
	}
}
