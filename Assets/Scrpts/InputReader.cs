using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour
{

    public static InputReader Instance { get; private set; }
    public InputActionAsset InputActions;

    InputAction moveAction;

    private Vector2 moveInput;
    public Vector2 MoveInput => moveInput;

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
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        moveAction = InputSystem.actions.FindAction("Move");

        moveAction.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        moveAction.canceled += ctx => moveInput = Vector2.zero;



    }

    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
    }
}
