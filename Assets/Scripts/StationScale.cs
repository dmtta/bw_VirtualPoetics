using UnityEngine;
using System.Collections;

public class StationScale : MonoBehaviour {


	void Update() {
		if (Time.timeSinceLevelLoad < 90f) {			
						transform.localScale -= new Vector3 (0.015F, 0.015F, 0.015F);
				}
		}
}
