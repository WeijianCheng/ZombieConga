using UnityEngine;

public class Lose2 : MonoBehaviour {
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(470, 240, 100, 50), "Restart")){
			LoadLevel();
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	void LoadLevel() {
		
		
		Application.LoadLevel("Level2");
	}
}