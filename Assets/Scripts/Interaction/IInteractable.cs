using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    //What gets called when we left click on this object
    void OnInteract();
    //The prompt that shows up if aiming at it
    string GetPrompt();
}
