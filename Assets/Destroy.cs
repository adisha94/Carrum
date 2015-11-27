using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
	void OnCollisionEnter( Collision col )
	{
		if (col.gameObject.name == "Sphere 1")
		{
			Destroy(col.gameObject);
		}
	}
}
