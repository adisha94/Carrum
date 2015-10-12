using UnityEngine;
using System.Collections;


public class Dynamics : MonoBehaviour
{

	public float initialX;
	public float initialZ;
	private float initialY = 0;
	private float x = Input.GetAxis("Horizontal");
	private float y = 0;
	private float z = Input.GetAxis("Vertical");
	public Vector3 initialPosition;
	public ActivateTrigger activate;

	GameObject player;

	// Use this for initialization

	void Start ()
	{
		initialPosition = new Vector3(initialX, initialY, initialZ); // initial position of player. We set y to 0 so object sticks to the ground

	}



	// should script represent an entire turn of events or seperate scripts recting the difference sequence of events in the turning of the striker object


	// Update is called once per frame
	void Update ()
	{

	}


	// restricted player movement
	// initial turn algorithm
	void FixedUpdate()
	{
		Algorithm1 ();

	}


	/**
	 * This method describes one version of the turning algorithm
	 * 
	 */
	void Algorithm1()
	{
		bool hit = Input.GetButton("Fire1");
		// sequence of turn
		// move to adjust x
		float gettingXMovement = x;
		// hit button to set angualar position
		if ( hit == true)
		{
			/// move to adjust
			float gettingZMovement = z;
			if ( hit == true )
			{
				// display power meter
				ActivateTrigger trig = new ActivateTrigger(); // activate the power meter				 
				if (hit == true)
				{
					// move striker
				}
			}		
		};
	}


	}

	void LateUpdate()
	{
		Camera_Player_Focus cam = new Camera_Player_Focus();
	}
}
