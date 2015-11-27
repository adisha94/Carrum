using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

	public float range;
	// Update is called once per frame
	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}
	void Update()
	{
		MovementMethod();
	}


	void MovementMethod()
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		float xPos = (h * range) * Time.deltaTime;
		float yPos = (v * range) * Time.deltaTime;
		Vector3 move = new Vector3 (xPos, 0, yPos);
//		transform.position = new Vector3 (xPos, 0, yPos); // updates the position of the current object
		rb.AddForce (move, ForceMode.Force);
	}


	void RotationMethod()
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		GetComponent<Rigidbody>().AddTorque (transform.up * range);
		GetComponent<Rigidbody>().AddTorque (transform.right * range);
	}
	/**
	 * updates the physics based functions
	 **/
	void FixedUpdate()
	{
	}

}
