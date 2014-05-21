using UnityEngine;
using System.Collections;

public class PlanetScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {
		if (Time.timeSinceLevelLoad < 120f) {	
						transform.localScale += new Vector3 (0.05F, 0.05F, 0.05F);
				}
	}
}
