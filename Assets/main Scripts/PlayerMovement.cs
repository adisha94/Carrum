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
	 * Physics frame updating such as movemnet
	 **/
	void FixedUpdate () 
	{
		KeyBoardInput ();
	}


	void KeyBoardInput()
	{
		// If we want to control using the keyboard
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");	

		Vector3 keyboardMovement = new Vector3 (force * moveHorizontal, 0.0f, force * moveVertical);
			
		rigidbody.AddForce (keyboardMovement);

	}



	/**
	 * camera movement updates
	 **/
	void lateUpdate()
	{

	}


	//aiming marker made for engines such 
	void MouseRotate()
	{
		float mouseMoveHorizontal = Input.GetAxis("MouseX");
		float mouseMoveVertical = Input.GetAxis ("MouseY");

		Vector3 mouseMovement = new Vector3 (force * mouseMoveHorizontal, 0, force * mouseMoveVertical);
		rigidbody.AddForce (mouseMovement);
	}
}
