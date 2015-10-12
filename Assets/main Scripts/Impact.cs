using UnityEngine;
using System.Collections;


/// <summary>
///  This script will help for dealing with object behavior when hit by another object.
/// 
/// </summary>
public class Impact : MonoBehaviour
{

	private GameObject source; // attached object
	private GameObject target; // targeted object
	public float force;
	// Use this for initialization
	void Start ()
	{
		force = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}


	void OnColliderEnter(GameObject other)
	{
//		Vector3 move = new Vector3 (x, 0, z); move forward
		// behavior if the object hits another object
	}
}
