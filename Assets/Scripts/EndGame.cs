using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Time.timeSinceLevelLoad > 5f ) {
			AutoFade.LoadLevel("Death" ,1,1,Color.black);
		}
	}
}
