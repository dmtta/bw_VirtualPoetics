using UnityEngine;
using System.Collections;


public class OVRotate : MonoBehaviour {
	
		void Update() {
			transform.Rotate(Time.deltaTime, 0, 0);
		transform.Rotate(0, Time.deltaTime*5, Time.deltaTime*5, Space.World);
		}
	}