using UnityEngine;
using System.Collections;

public class GrowText : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
		if (Time.timeSinceLevelLoad < 2f) {
			GetComponent<TextMesh> ().text = ""; 
		} else if (Time.timeSinceLevelLoad < 5f) {
			GetComponent<TextMesh> ().text = "Growing up";
		} else if (Time.timeSinceLevelLoad < 9f) {
			GetComponent<TextMesh> ().text = "Wondering";
		} else if (Time.timeSinceLevelLoad < 13f) {
			GetComponent<TextMesh> ().text = "What lied behind that door?";
		} else if (Time.timeSinceLevelLoad < 18f) {
			GetComponent<TextMesh> ().text = " ";
		}
	}
}
