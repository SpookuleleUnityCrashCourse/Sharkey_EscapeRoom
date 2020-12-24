using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBox : MonoBehaviour, IInteractable
{

    public GameObject doorObject;//because later on we need to refer to an object that will be destroyed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInteract()//Need this bc OnInteract() is in IInteractable 
    {
        Destroy(doorObject);//destroys whatever you put in the inspector for DoorObject
    }

    public string GetPrompt()//Need this bc OnInteract() is in IInteractable
    {
        return "Open Door";
    }


}
