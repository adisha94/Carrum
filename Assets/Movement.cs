using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

	public float range;
	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}



	void Update()
	{
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		if (Physics.Raycast (transform.position, fwd, 10))
		{
			print("There is something in front of the selected object");
		}
	}

	/**
	 * updates the physics based functions
	 **/
	void FixedUpdate()
	{
		MovementMethod();
	}
	
	/**
	 * Main movement method
	 **/
	void MovementMethod()
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		float xPos = (h * range) * Time.deltaTime;
		float yPos = (v * range) * Time.deltaTime;
		Vector3 move = new Vector3 (xPos, 0, yPos);
//		transform.position = new Vector3 (xPos, 0, yPos); // updates the position of the current object
		rb.AddForce (new Vector3(xPos, 0, yPos), ForceMode.Acceleration);
	}

	/**
	 * Main rotation method
	 *
	 */
	void RotationMethod()
	{
		GetComponent<Rigidbody>().AddTorque (transform.up * range);
		GetComponent<Rigidbody>().AddTorque (transform.right * range);
	}
}