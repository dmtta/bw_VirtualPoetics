using UnityEngine;
using System.Collections;

public class Babel2Text : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
		if (Time.timeSinceLevelLoad < 2f) {
			GetComponent<TextMesh> ().text = ""; 
		} else if (Time.timeSinceLevelLoad < 5f) {
			GetComponent<TextMesh> ().text = "With every step up";
		} else if (Time.timeSinceLevelLoad < 9f) {
			GetComponent<TextMesh> ().text = "Closer to the skies";
		} else if (Time.timeSinceLevelLoad < 13f) {
			GetComponent<TextMesh> ().text = " ";
		}
	}
}

