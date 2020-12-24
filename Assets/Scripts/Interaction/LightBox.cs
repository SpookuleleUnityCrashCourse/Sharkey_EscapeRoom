using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBox : MonoBehaviour, IInteractable
{

    public Light lightObject;
    public Lighting newLighting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInteract()//needs this in order to be use IInteractable
    {
        lightObject.color = newLighting.lightColor;
    }

    public string GetPrompt()
    {
        return "Change Lighting";
    }
}
