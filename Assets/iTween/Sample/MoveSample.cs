using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{	
	void Start(){
		iTween.MoveTo(gameObject, iTween.Hash("y", 3.5, "easeType", "easeInOutExpo", "delay", 5, "time",15));
	}
}

