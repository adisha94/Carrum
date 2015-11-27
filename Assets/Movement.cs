using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

	public float range;
	// Update is called once per frame
	void Update ()
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		float xPos = (h * range) * Time.deltaTime;
		float yPos = (v * range) * Time.deltaTime;
		transform.position = new Vector3 (xPos, 0, yPos); // updates the position of the current object
	}

}
