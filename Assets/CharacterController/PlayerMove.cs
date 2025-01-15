using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController characterController; 
    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Actions.moveEvent += moveChar;
        characterController = this.GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        moveChar();
    }
    void moveChar()
    {
        characterController.Move(direction * Time.deltaTime * moveSpeed);
    }
}
