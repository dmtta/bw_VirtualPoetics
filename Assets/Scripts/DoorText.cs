using UnityEngine;
using System.Collections;

public class DoorText : MonoBehaviour {

	// Update is called once per frame
	void Update () {

				if (Time.timeSinceLevelLoad < 2f) {
						GetComponent<TextMesh> ().text = ""; 
				} else if (Time.timeSinceLevelLoad < 5f) {
						GetComponent<TextMesh> ().text = "Everything starts and ends with darkness.";
				} else if (Time.timeSinceLevelLoad < 7f) {
						GetComponent<TextMesh> ().text = "";
				} else if (Time.timeSinceLevelLoad < 10f) {
						GetComponent<TextMesh> ().text = "Enter the light.";
				} else if (Time.timeSinceLevelLoad < 20f) {
						GetComponent<TextMesh> ().text = " ";
				}
		}
	}
