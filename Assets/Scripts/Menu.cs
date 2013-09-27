using UnityEngine;
using System.Collections;

/* This class handles the menu shown on the splash screen */

public class Menu : MonoBehaviour {
	
	float buttonWidth = 200.0f;
	float buttonHeight = 100.0f;

	void OnGUI(){
		
		if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2, Screen.height/2-buttonHeight, buttonWidth, buttonHeight),"Play"))
        		Application.LoadLevel ("Main");
		if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2, Screen.height/2, buttonWidth, buttonHeight),"Quit"))
       		 	Application.Quit();
	
	}
}
