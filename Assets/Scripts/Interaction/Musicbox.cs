using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicbox : MonoBehaviour, IInteractable
{
	public AudioSource audioSource;
	
	public void OnInteract()//needs this in order to be use IInteractable
	{
		audioSource.Play();
	}

	public string GetPrompt()
	{
		return "Play Song";
	}
}
