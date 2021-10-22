using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do : MonoBehaviour {

	[SerializeField] private Animator myAnimationController;

	private void  OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			myAnimationController.SetBool("playSpin", true);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Cube"))
		{
			myAnimationController.SetBool("playSpin", false);
		}
	}
}
