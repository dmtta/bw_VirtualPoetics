using UnityEngine;
using System.Collections;

public class beachesText : MonoBehaviour {
	
	// Update is called once per frame
void Update () {
	
	if (Time.timeSinceLevelLoad < 2f) {
		GetComponent<TextMesh> ().text = ""; 
	} else if (Time.timeSinceLevelLoad < 5f) {
		GetComponent<TextMesh> ().text = "When the world struck back";
	} else if (Time.timeSinceLevelLoad < 10f) {
		GetComponent<TextMesh> ().text = "Did anybody care?";
	} else if (Time.timeSinceLevelLoad < 15f) {
		GetComponent<TextMesh> ().text = " ";
	} 
}
}

