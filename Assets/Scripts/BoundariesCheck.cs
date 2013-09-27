using UnityEngine;
using System.Collections;

/* this class makes sure the player stays within the screen
 * boundaries. If not, the game is over */

public class BoundariesCheck : MonoBehaviour {
	
	
	float minX = -11.0f; //left boundary
	float maxX = 11.0f;  //right boundary
	private InGameMenu gui;
	

	void Update () {
		if(gameObject.transform.position.x < minX || gameObject.transform.position.x > maxX){
			
			Destroy (gameObject);
			GameObject camera = GameObject.Find("Main Camera");
			gui = camera.GetComponent<InGameMenu>();
			gui.showResume = false;
			gui.showGui = true;
			gui.showGameOver = true;
		}
	}
	

}
