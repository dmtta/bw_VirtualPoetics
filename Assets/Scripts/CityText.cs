using UnityEngine;
using System.Collections;

public class CityText : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
		if (Time.timeSinceLevelLoad < 2f) {
			GetComponent<TextMesh> ().text = ""; 
		} else if (Time.timeSinceLevelLoad < 5f) {
			GetComponent<TextMesh> ().text = "So, did you find it?";
		} else if (Time.timeSinceLevelLoad < 10f) {
			GetComponent<TextMesh> ().text = "Poetry within destruction?";
		} else if (Time.timeSinceLevelLoad < 15f) {
			GetComponent<TextMesh> ().text = " ";
		} 
	}
}

