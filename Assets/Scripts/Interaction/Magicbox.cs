using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magicbox : MonoBehaviour, IInteractable
{
    public ParticleSystem particles;
    
    public void OnInteract()//needed to have IInteractable. Note how it's different than music box's OnInteract()
    {
        particles.Play();
    }

    public string GetPrompt()
    {
        return "Start Magic";
    }
}
