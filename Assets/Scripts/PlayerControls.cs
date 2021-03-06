﻿using UnityEngine;
using System.Collections;

//This is the official Unity Reference script for controls. I modified it to fit my needs and made sure to understand what everything does.
public class PlayerControls : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    //Declaring values that can be changed in the Unity editor later.

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //This catches the CharacterController that is connected to the player object. 
    }

    void Update()
    {
        if (characterController.isGrounded)
        {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0);
            moveDirection *= speed;
            //If the player is on the ground then we can make it move by getting the input from the keyboard buttons that we set previously in Unity.
            //We can set how fast it moves because we set a "Speed" variable.

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
                //After pressing the jump button the character jumps.
            }
        }

        
        moveDirection.y -= gravity * Time.deltaTime;

     
        characterController.Move(moveDirection * Time.deltaTime);
        //This makes the actual player gameObject in Unity to move.
    }
}