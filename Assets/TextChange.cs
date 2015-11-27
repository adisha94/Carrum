using UnityEngine;
using System.Collections;

public class TextChange : MonoBehaviour 
{
	// declaring variables
	public GUIText currentText;
	private int score;


	void Start ()
	{
		currentText.text = "";
		score = 0;
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "plane")
		{
			currentText.text = "Collision occured";
			score+= 10;
		}
	}

	void SetText()
	{
		currentText.text = "Idle Position";
	}

}
