using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public static int score =0 ;  
	public static int life =3 ;// The player's score.

	
	
	Text text;    
	
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		score = 0;
		life = 3;
	}
	
	
	void Update ()
	{
		////if (Application.loadedLevel == "CongaScene") {
		//level = "Level 1";
		//} else if (Application.loadedLevel == "Level2") {
		//level = "Level 2";
		///}
		
		
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + score + "/Lives: " + life + "/Level: " + Application.loadedLevel;
	}
}
