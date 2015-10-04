using UnityEngine;
using System.Collections;

public class Camera_Player_Focus : MonoBehaviour
{

	private Vector3 focus;
	public GameObject player;
	private Camera main_focusCamera;

	// Use this for initialization
	void Start ()
	{
		focus = transform.position; // movement with the player
	}
	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = player.transform.position + focus;
	}


}
