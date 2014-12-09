using UnityEngine;
using System.Collections;

public class Camera_Player_Focus : MonoBehaviour {

	private Vector3 focus;
	public GameObject player;
	private Camera focusCamera;
	// Use this for initialization
	void Start ()
	{
		focus = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () // used for code such as last player location and all
	{
			transform.position = player.transform.position + focus;
	}


}
