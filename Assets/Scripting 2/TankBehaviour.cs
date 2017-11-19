using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBehaviour : MonoBehaviour {

	public float TranslateSpeed = 1f;
	public float rotateSpeed = 1f;

	public GameObject mine = null;

	protected Color _originalColor;


	void Start()
	{
		Transform renderers = transform.Find("TankRenderers");
		_originalColor = renderers.Find("TankTurret").GetComponent<Renderer>().material.GetColor("_Color");
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * Time.deltaTime * TranslateSpeed);
			transform.Find("TankRenderers").transform.Find("TankTurret").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(-Vector3.forward * Time.deltaTime * TranslateSpeed);
			transform.Find("TankRenderers").transform.Find("TankTurret").GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
		}
		else
			transform.Find("TankRenderers").transform.Find("TankTurret").GetComponent<Renderer>().material.SetColor("_Color", _originalColor);


		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(-Vector3.up * Time.deltaTime * rotateSpeed);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (mine != null)
			{
				// Esta linea hace lo mismo que las 2 siguientes
				//GameObject placedMine = GameObject.Instantiate(mine, transform.position - (transform.forward * 1f), Quaternion.identity);

				GameObject placedMine = GameObject.Instantiate(mine);
				placedMine.transform.position = transform.position - (transform.forward*1f) ;

				placedMine.AddComponent<MineBehaviour>();
			}
		}
	}
}
