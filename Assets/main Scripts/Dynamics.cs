﻿using UnityEngine;
using System.Collections;


public class Dynamics : MonoBehaviour
{

	public float initialX;
	public float initialZ;
	private float initialY = 0;
	private float x = 0;//Input.GetAxis("Horizontal");
//	private float y = 0;
	private float z = 0;//Input.GetAxis("Vertical");
//	public Vector3 initialPosition;
	public ActivateTrigger activate;

	GameObject player;

	// Use this for initialization
	void Start ()
	{
//		initialPosition = new Vector3(initialX, initialY, initialZ); // initial position of player. We set y to 0 so object sticks to the ground

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
		// sequence of turn
		// move to adjust x axis pointer
		x = Input.GetAxis("Horizontal");
		float gettingXMovement = x;
		// hit button to set angualar position
		bool hit = Input.GetButton("Fire1");
		if ( hit == true)
		{
			print("You have hit the button");
//			hit = Input.GetButton("Fire1");
//			/// move to adjust
//			z = Input.GetAxis("Vertical");
//			float gettingZMovement = z;
//			if ( hit == true )
//			{
//				hit = Input.GetButton("Fire1");
//				// display power meter
//				if (hit == true)
//				{
//					hit = Input.GetButton("Fire1");
////					activate.DoActivateTrigger(); // moves the object
////					ActivateTrigger trigger = new ActivateTrigger();
////					trigger.DoActivateTrigger();
//					if (hit == true)
//					{
//						// move striker
//					}
//
//				}
//			}		
		}
	}


	void Algorithm2()
	{
		/**
		 * 1. bool a checker for user input
		 * 2. declare a float to move across the board
		 * 
		 * Further developement is needed for this developemnt
		 * 
		 */
	}

	/**
	 * Camera update functions go here.
	 **/
	void LateUpdate()
	{
//		Camera_Player_Focus cam = new Camera_Player_Focus();
	}
}
