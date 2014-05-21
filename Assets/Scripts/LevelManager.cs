using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public static int currentLevel = -1;
	public static bool levelChange = false;
	public static int nextLevel = currentLevel+1;
	public int debugLevel = nextLevel;


	// Use this for initialization
	void Start () {
	
		currentLevel = 0;
		levelChange = false;

	}
	
	// Update is called once per frame
	void Update () {
	if (nextLevel == 8) {
		nextLevel = 0;		
		}

	}
}
