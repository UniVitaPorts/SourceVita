using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApp : MonoBehaviour {

	public void QuitGame()
	{
		Debug.Log("App closed. Good job, soldier!");
		Application.Quit();
	}
    

}
