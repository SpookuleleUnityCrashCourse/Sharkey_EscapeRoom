using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedbox : MonoBehaviour, IInteractable
{

    public Player player;
    public PlayerData powerUpData;
    

    public void OnInteract()//needed so that the player can do IInteractable w/ it
    {
        player.playerData = powerUpData;
    }

    public string GetPrompt()
    {
        return "Give Super Speed";
    }
}
