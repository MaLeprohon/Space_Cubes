using UnityEngine;
using System.Collections;

/* This class handles the control input for the player */

public class PlayerControls : MonoBehaviour {
	
	private int jumpForce = 75;
	private bool isGrounded = false;
	

	void Update () {
		
		//determines if player is on the ground
		isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.7f);
		
		//sets controls for jumping
		if(Input.GetButton("Jump") || Input.GetKey("w")){
			if(isGrounded){
				jump();
			}
		}
		
 		if (Input.GetKey ("d")) {
        	gameObject.transform.Translate(Vector3.right* Time.deltaTime * 5, Space.World);
   		}
		

	 	if (Input.GetKey ("a")){
        	gameObject.transform.Translate(Vector3.left * Time.deltaTime * 5, Space.World);
   		}
		
	}
	

	void jump(){
		//if player is grounded, allows to jump
		if(isGrounded) {
			rigidbody.AddForce(Vector3.up  * jumpForce);
		}
	}
}	

