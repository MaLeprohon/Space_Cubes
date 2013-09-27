using UnityEngine;
using System.Collections;

/* This class handles the in game menu */

public class InGameMenu : MonoBehaviour {

	float buttonWidth = 200.0f;
	float buttonHeight = 100.0f;
	public bool showGui = false; //checks if GUI should be shown
	public bool showResume = true; //checks if 'resume' button should be present
	public bool showGameOver = false; //checks if player lost
	public bool showWinner = false; //checks if player won
	

	// Update is called once per frame
	void Update () {
		//on "ESC" show menu
		if(Input.GetKeyDown(KeyCode.Escape)){
			
			if(Time.timeScale == 1.0f){
				Time.timeScale = 0.0f;
				showGui = true;
			} else if(Time.timeScale == 0.0f){
				Time.timeScale = 1.0f;
				showGui = false;
			}
		}
	}
	
	
	
	void OnGUI(){
		if(showGui){
			
			if(showResume){
				if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2, Screen.height/2-buttonHeight, buttonWidth, buttonHeight),"Resume")){
		        		Time.timeScale = 1.0f;
						showGui = false;
				}
			}
			
			if(showGameOver){
				GUI.Box(new Rect(Screen.width/2-125, Screen.height/2-40, 250, 250), "Game Over!");
			}
			if(showWinner){
				GUI.Box(new Rect(Screen.width/2-125, Screen.height/2-40, 250, 250), "You won!");
			}
			
			if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2, Screen.height/2, buttonWidth, buttonHeight),"Reload")){
		        Time.timeScale = 1.0f;		
				Application.LoadLevel ("Main");
			}
			
			if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2, Screen.height/2+buttonHeight, buttonWidth, buttonHeight),"Quit"))
	       		 	Application.Quit();
				
		}
	}
}
