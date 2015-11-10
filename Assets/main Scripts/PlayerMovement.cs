using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float force; // numerical value of physical force constant that will be applied to the players during the game

	/**
	 * Player has to move within a certain area. 
	 * That area is where the player is restricted to move. 
	 * Player Cannot Move beyong that restricted area.
	 * 
	 * This script documents and writes the program for the movement of the player using keyboard and mouse.
	 **/

	// Use this for initialization
	void Start () 
	{
		
	}
	
	/**
	 * All physics related movement and frame updates get done here.  
	 **/
	void FixedUpdate ()
	{
		KeyBoardInput ();
//		ControllerInput ();
	}

	// this function is for moving the striker with the keyboard
	void KeyBoardInput()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 keyboardMovement = new Vector3(force * moveHorizontal, 0, force * moveVertical);
		GetComponent<Rigidbody>().AddRelativeForce (keyboardMovement);

	}

	
	/**
	 * camera movement updates
	 **/
	void lateUpdate()
	{

	}

}
