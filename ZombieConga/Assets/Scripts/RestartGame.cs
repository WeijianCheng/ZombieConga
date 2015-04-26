
using UnityEngine;
using System.Collections;

public class RestartGame : MonoBehaviour {
	
	void OnGUI()
	{
		if (GUI.Button (new Rect (470, 200, 100, 50), "Restart")) {
			LoadLevel();
		}
		if(GUI.Button(new Rect(470, 300, 100, 50), "Next Level")){
			LoadLevel2(); 
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	void LoadLevel() {
		
		
		Application.LoadLevel("CongaScene");
		
	}
	void LoadLevel2 () {
		Application.LoadLevel ("Level2");
	}
}
