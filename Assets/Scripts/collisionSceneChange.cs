using UnityEngine;
using System.Collections;

public class collisionSceneChange : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
				foreach (ContactPoint contact in collision.contacts) {
						Debug.DrawRay (contact.point, contact.normal, Color.white);
				}
				if (collision.relativeVelocity.magnitude > 2) {
						LevelManager.levelChange = true;
				}
		}
}
