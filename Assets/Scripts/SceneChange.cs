using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

		LevelManager.levelChange = false;

				if (LevelManager.nextLevel < 11) {
						LevelManager.nextLevel++;
				} else {
						LevelManager.nextLevel = 0;
				}
		}

	
	// Update is called once per frame
	void Update () {
		
		// change the scene after trigger
		if ( LevelManager.levelChange == true) {

			LevelManager.levelChange = false;


			if(LevelManager.nextLevel == 0 || LevelManager.nextLevel == 1 || LevelManager.nextLevel == 11){
			AutoFade.LoadLevel(LevelManager.nextLevel,1,1,Color.black);
			}else{
				AutoFade.LoadLevel(LevelManager.nextLevel,1,1,Color.white);
			}
		}
		
		// change the scene if you press R
		if (Input.GetKey (KeyCode.R) ) 
		{
			LevelManager.levelChange = true;	

		}
		
	}
}