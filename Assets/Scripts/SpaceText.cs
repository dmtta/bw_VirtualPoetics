using UnityEngine;
using System.Collections;

public class SpaceText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

				if (Time.timeSinceLevelLoad < 10f) {
						GetComponent<TextMesh> ().text = ""; 
				} else if (Time.timeSinceLevelLoad < 15f) {
						GetComponent<TextMesh> ().text = "A final jump.";
				} else if (Time.timeSinceLevelLoad < 18f) {
						GetComponent<TextMesh> ().text = "";
				} else if (Time.timeSinceLevelLoad < 22f) {
						GetComponent<TextMesh> ().text = "Into the darkness.";
				} else if (Time.timeSinceLevelLoad < 25f) {
						GetComponent<TextMesh> ().text = "";
				} else if (Time.timeSinceLevelLoad < 30f) {
						GetComponent<TextMesh> ().text = "A final fall.";
				} else if (Time.timeSinceLevelLoad < 32f) {
						GetComponent<TextMesh> ().text = "";
				} else if (Time.timeSinceLevelLoad < 35f) {
						GetComponent<TextMesh> ().text = "Might as well put on some music.";
				} else if (Time.timeSinceLevelLoad < 39f) {
						GetComponent<TextMesh> ().text = "";
				} else if (Time.timeSinceLevelLoad < 41f) {
						GetComponent<TextMesh> ().text = "You'll burn like a meteor.";
				} else if (Time.timeSinceLevelLoad < 58f) {
						GetComponent<TextMesh> ().text = " ";
		} else if (Time.timeSinceLevelLoad < 58f) {
			GetComponent<TextMesh> ().text = "You are coming back home.";
		}
	}
	}
