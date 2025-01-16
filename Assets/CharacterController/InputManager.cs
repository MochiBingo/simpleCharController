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
    public void OnMove(InputAction.CallbackContext context)
    {
            //Debug.Log($"Recieving Move Input {context.ReadValue<Vector2>()}");
            Actions.moveEvent?.Invoke(context.ReadValue<Vector2>());     
    }
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Actions.interactEvent?.Invoke();
        }
        if (context.canceled)
        {
            Actions.interactEventCanceled?.Invoke();
        }
    }
}
public static class Actions
{
    public static Action<Vector2> moveEvent;
    public static Action interactEvent;
    public static Action interactEventCanceled;
}
