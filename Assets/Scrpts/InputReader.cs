using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{

    InputActionAsset InputActions;

    InputAction moveAction;

    private Vector2 moveInput;

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();

    }

    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
    }
}
