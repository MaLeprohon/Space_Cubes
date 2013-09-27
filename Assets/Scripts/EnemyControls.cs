using UnityEngine;
using System.Collections;

/* This class handles the enemy units movement */

public class EnemyControls : MonoBehaviour {
	
	float distance = .80f;

	
	void Update () {
		
		//defining what forward is
		var forward = transform.TransformDirection(Vector3.left);
		
		//if enemy hit something, they will stop
		if(Physics.Raycast(transform.position, forward, distance)){
			transform.Translate(0,0,0);
		}
		else{
			//Translate used to move the enemies
			transform.Translate(Vector3.left * Time.deltaTime * 4);
		}
		
		
	}
	
}
