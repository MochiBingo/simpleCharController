using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, GameInput.IPlayerActions
{
    private GameInput gameInput;

    void Awake()
    {
        gameInput = new GameInput();
        gameInput.Player.Enable();
        gameInput.Player.SetCallbacks(this);
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnMove(InputAction.CallbackContext context)
    {
     
            Debug.Log($"Recieving Move Input {context.ReadValue<Vector2>()}");
            Actions.moveEvent?.Invoke(context.ReadValue<Vector2>());
        
        
    }
}
public static class Actions
{
    public static Action<Vector2> moveEvent;
}
