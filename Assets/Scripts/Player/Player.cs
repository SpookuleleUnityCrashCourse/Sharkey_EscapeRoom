using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform tform;
    public CharacterController controller;
    public PlayerData playerData;
    public Camera cam;
    public Vector2 movementDirection;
    public float amountToRotateX;
    public float amountToRotateY;
    public bool running;


    //Every frame, update movement and rotation
    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        //Set speed to walking speed, but change it to running speed if we are running
        float speed = playerData.walkingSpeed;
        if (running)
            speed = playerData.runningSpeed;

        //Convert the movement direction to world direction by multiplying y by forward and x by right
        Vector3 worldDirection = 
            movementDirection.y * tform.forward + 
            movementDirection.x * tform.right;

        //Finally, get the velocity. Remember to multiply by Time.deltaTime for smooth motion in Update()!
        Vector3 velocity = Time.deltaTime * speed * worldDirection;

        //Move the character controller by velocity
        controller.Move(velocity);
    }

    void Rotate()
    {    
        //Rotate the player by x and the camera by y.
        transform.Rotate(Vector3.up, amountToRotateX * playerData.rotationSensitivity * Time.deltaTime);
        cam.transform.Rotate(Vector3.right, amountToRotateY * playerData.rotationSensitivity * Time.deltaTime);
        
        //Clamp y angle so we can't look above or below a certain angle.
        ClampYAngle();
    }

    void ClampYAngle()
    {
        //Don't let cam angle go above or below 80 degrees
        float angle = cam.transform.localEulerAngles.x;
        
        if (angle > 180f)
            angle -= 360f;
        
        cam.transform.localEulerAngles = Vector3.right * Mathf.Clamp(angle, -40f, 40f);
    }
    
}
