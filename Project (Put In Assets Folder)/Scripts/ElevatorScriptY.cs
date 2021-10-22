using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScriptY : MonoBehaviour {

	public GameObject moveplatform;

	private void OnTriggerStay(){
		float val1 = 0.1f; 
		moveplatform.transform.position += moveplatform.transform.up * val1;
	}
}
