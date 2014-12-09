using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Point_Score : MonoBehaviour 
{

	// declaring variables

	public Text scoreText;
	public Text winText;
	public Text queenText;
	public Text blackBrownText;
	private int score;

	// Initializing variables on here
	void Start () 
	{
		scoreText.text = "";
		winText.text = "";
		SetScoreText ();
		queenText.text = "";
		blackBrownText.text = "";
		score = 0;
	}
	
	// what to do if black or white Goti is put into the goal
	void OnCollidorEnter_Black_or_Brown (Collider other)
	{
		if (other.gameObject.tag == "Black") // if we put the black Goti in the goal
		{
			blackBrownText.text = "Good job you got 10 points!";
			other.gameObject.SetActive(false);
			score = score + 10;
		}

		if (other.gameObject.tag == "Brown") // if we put the brown Goti in the goal
		{
			blackBrownText.text = "Good job, you got 20 points because you got the brown goti in the goal";
			other.gameObject.SetActive(false);
			score = score + 20;
		}
	}

	// what do we do if we get the queen inside the goal
	void OnColliderEnter_Queen (Collider other) // if we put the Goti in the goal
	{
		if (other.gameObject.tag == "Queen")
		{
			queenText.text = "Good Job, you got the Queen in, now score one more Goti in the first try to retrieve the queen";
			if (other.gameObject.tag == "Black" || other.gameObject.tag == "Brown") // if a black goti or a brown goti enters the goal, then we increase the player score by 10 if its black
																					// and 20 if its brown
			{
				OnCollidorEnter_Black_or_Brown(other);
				other.gameObject.SetActive(false);
				if (other.gameObject.tag == "Black")
				{
					score = score + 10;
				}
				if (other.gameObject.tag ==  "Brown")
				{
					other.gameObject.SetActive(false);
					score = score + 20;
				}

			}
		}
	}

	void SetScoreText ()
	{	
		scoreText.text = "Player Score: " + score.ToString();
		winText.text = "Good Job! You win the game";

	}
}