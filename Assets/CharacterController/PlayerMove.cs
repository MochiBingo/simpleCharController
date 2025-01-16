using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController characterController; 
    public float moveSpeed = 5.0f;
    private Vector2 moveVector = Vector2.zero;
    public GameObject interact1;
    public GameObject interact2;
    public GameObject interact3;
    
    // Start is called before the first frame update
    void Start()
    {
        Actions.moveEvent += updateMoveVector;
        Actions.interactEvent += interactOne;
        Actions.interactEvent += interactTwo;
        Actions.interactEvent += interactThreeStart;
        Actions.interactEventCanceled += interactThreeCancel;
        characterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveChar(moveVector);
    }
    void moveChar(Vector2 moveVector)
    {
        characterController.Move(moveVector * moveSpeed * Time.deltaTime );
    }
    void updateMoveVector(Vector2 inputVector)
    {
        moveVector = inputVector;
    }
    void interactOne()
    {
        interact1.transform.position += new Vector3(0, -1, 0);
        
    }
    void interactTwo()
    {
        interact2.transform.position += new Vector3(1, 0, 0);
        
    }
    void interactThreeStart()
    {
        interact3.transform.position += new Vector3(0, 1, 0);
        
    }
    void interactThreeCancel()
    {
        interact3.transform.position += new Vector3(0, -1, 0);
    }
}
