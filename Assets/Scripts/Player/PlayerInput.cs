using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	public Player player;

	//All we want to do in start is hide the cursor.
	void Start()
	{
		HideCursor();
	}

	//In update, so every frame...
	//Update the movement input and the turning input
	void Update()
	{
		MovementInput();
		TurningInput();
	}

	void MovementInput()
	{
		float x = Input.GetAxisRaw("Horizontal"); //Get x axis input, or A/D
		float y = Input.GetAxisRaw("Vertical"); //Get y axis input, or W/S
		player.movementDirection = new Vector2(x, y); //Set the player's movement direction based on input
		player.running = Input.GetKey(KeyCode.LeftShift); //Set if the player is running or not based on holding left shift
	}

	void TurningInput()
	{
		float mouseX = Input.GetAxisRaw("Mouse X"); //Get x mouse input
		float mouseY = Input.GetAxisRaw("Mouse Y"); //Get y mouse input
		player.amountToRotateX = mouseX; //set the appropriate amounts to rotate
		player.amountToRotateY = -mouseY;
	}
	
	void HideCursor()
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
}
