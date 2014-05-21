using UnityEngine;
using System.Collections;

public class CenotaphText : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
		if (Time.timeSinceLevelLoad < 2f) {
			GetComponent<TextMesh> ().text = ""; 
		} else if (Time.timeSinceLevelLoad < 5f) {
			GetComponent<TextMesh> ().text = "With everything gone.";
		} else if (Time.timeSinceLevelLoad < 10f) {
			GetComponent<TextMesh> ().text = "One last place to go";
		} else if (Time.timeSinceLevelLoad < 15f) {
			GetComponent<TextMesh> ().text = " ";
		} 
	}
}

