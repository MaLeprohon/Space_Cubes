using UnityEngine;
using System.Collections;

/* This class takes care of spawning enemies */

public class EnemyInstantiation : MonoBehaviour {

	public GameObject enemy;
	int maxEnemy = 30;
	int enemySpawned = 0;
	float spawnDelay = 1.0f;
	float instanceLifetime = 10.0f;
	private InGameMenu gui;
	

	void Start () {
		spawnEnemy();
	}
	
	//function to instantiate new enemies every 3 seconds
	void spawnEnemy(){
		GameObject enemyInstance;
		
		//Ramdomly spawn enemies either at ground level or a bit higher
		if(getRandomPosition() == 0){
			enemyInstance = Instantiate(enemy, new Vector3(11, -1.34f ,0), Quaternion.identity) as GameObject;
		} else {
			enemyInstance = Instantiate(enemy, new Vector3(11, 0.0f ,0), Quaternion.identity) as GameObject;
		}
		
		enemySpawned++;
		
		//Check if all enemy have spawned, if not spawn more, else the player wins.
		if(enemySpawned < maxEnemy){
			Invoke("spawnEnemy", spawnDelay);
		} else{
			GameObject camera = GameObject.Find("Main Camera");
			gui = camera.GetComponent<InGameMenu>();
			gui.showResume = false;
			gui.showGui = true;
			gui.showWinner = true;
		}
		
		//Destroys the instance after 10 seconds
		Destroy(enemyInstance, instanceLifetime);
	}
	
	
	int getRandomPosition(){
		return Random.Range (0, 2);
	}

}
