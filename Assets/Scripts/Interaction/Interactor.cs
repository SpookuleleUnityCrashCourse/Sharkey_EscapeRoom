using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactor : MonoBehaviour
{
    public CanvasGroup alphaGroup;
    public Text promptText;
    
    
    IInteractable focusedInteractable;
    
    void Update()
    { 
        CheckForInteractable();          
        RefreshDisplay();
        
        if(Input.GetButtonDown("Fire1"))
            Interact();
    }

    void RefreshDisplay()
    {
        if (focusedInteractable == null)
        {
            alphaGroup.alpha = 0f;
        }
        else
        {
            alphaGroup.alpha = 1f;
            promptText.text = focusedInteractable.GetPrompt();
        }
    }

    void CheckForInteractable()
    {
        RaycastHit hit;
        focusedInteractable = null;

        //This if statement gets called if the raycast happens
        //Stores the data of the hit in the hit variable
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2f))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
                focusedInteractable = interactable;
        }
    }

    void Interact()
    {
        focusedInteractable?.OnInteract();
    }
}
