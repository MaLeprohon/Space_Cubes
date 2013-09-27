using UnityEngine;
using System.Collections;

/* This class handles the player's collision and its health management */

public class PlayerCollider : MonoBehaviour {
	
	float distance = 0.70f;
	float curHealth = 1.0f;
	float decreaseRate = 0.5f;

	Vector2 size = new Vector2(300,50);
	
	//textures for the health bar
	public Texture2D healthBarEmpty;
	public Texture2D healthBarFull;
	
	private InGameMenu gui;
	
	
	
	void Update(){
	
		//defining what forward is
		var forward = transform.TransformDirection(Vector3.left);
		
		//if an enemy touches the placers, the current health decreases
		if(Physics.Raycast(transform.position, forward, distance)){
			
			if(curHealth >= 0){
				curHealth -= decreaseRate * Time.deltaTime;
			} else if(curHealth < 0){
				curHealth = 0;		
			}
			
			//when player is dead, destroy the gameobject and show menu
			if(curHealth == 0){
				Destroy(gameObject);
				
				GameObject camera = GameObject.Find("Main Camera");
				gui = camera.GetComponent<InGameMenu>();
				gui.showResume = false;
				gui.showGui = true;
				gui.showGameOver = true;
			}
		}

	}
	
	void OnGUI(){
		
			//GUI element for the healthbar
			GUI.DrawTexture(new Rect(100, 100, size.x, size.y), healthBarEmpty);
			GUI.DrawTexture(new Rect(100, 100, size.x * curHealth, size.y), healthBarFull);

	}
}
