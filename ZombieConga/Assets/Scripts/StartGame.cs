using UnityEngine;

public class StartGame : MonoBehaviour {
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(470, 240, 100, 50), "Start")){
			LoadLevel();
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	void LoadLevel() {
		
		
		Application.LoadLevel("CongaScene");
	}
}
