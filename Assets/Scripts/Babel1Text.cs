using UnityEngine;
using System.Collections;

public class Babel1Text : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
		if (Time.timeSinceLevelLoad < 2f) {
			GetComponent<TextMesh> ().text = ""; 
		} else if (Time.timeSinceLevelLoad < 5f) {
			GetComponent<TextMesh> ().text = "You can only imagine";
		} else if (Time.timeSinceLevelLoad < 9f) {
			GetComponent<TextMesh> ().text = "how hard the climb will be.";
		} else if (Time.timeSinceLevelLoad < 13f) {
			GetComponent<TextMesh> ().text = "Get closer.";
		} else if (Time.timeSinceLevelLoad < 18f) {
			GetComponent<TextMesh> ().text = " ";
		}
	}
}
