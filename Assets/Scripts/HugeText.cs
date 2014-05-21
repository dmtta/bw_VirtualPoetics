using UnityEngine;
using System.Collections;

public class HugeText : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
		if (Time.timeSinceLevelLoad < 2f) {
			GetComponent<TextMesh> ().text = ""; 
		} else if (Time.timeSinceLevelLoad < 5f) {
			GetComponent<TextMesh> ().text = "Ambition";
		} else if (Time.timeSinceLevelLoad < 9f) {
			GetComponent<TextMesh> ().text = "Outgrew the world";
		} else if (Time.timeSinceLevelLoad < 13f) {
			GetComponent<TextMesh> ().text = "Had to get out";
		} else if (Time.timeSinceLevelLoad < 17f) {
			GetComponent<TextMesh> ().text = " ";
		}
	}
}