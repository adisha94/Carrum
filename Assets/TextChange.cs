using UnityEngine;
using System.Collections;

public class TextChange : MonoBehaviour 
{
	// declaring variables
	public GUIText sampleText;
	public GUIText currentText;
	public GUIText targetText;
	private int score;
	// Use this for initialization
	void Start ()
	{
		sampleText.text = "";
		currentText.text = "Idle Position";
		targetText.text = "";
	}

	void OnColliderEnter(Collider other)
	{
		currentText.text = "Collision occured";
	}

}
