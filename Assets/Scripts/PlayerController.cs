using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 50f;
    public InputAction MoveAction;
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable the MoveAction when the game starts   
        MoveAction.Enable();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Get the input from the MoveAction and store it in moveInput
        moveInput = MoveAction.ReadValue<Vector2>();

        // Move the player based on the input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        // Rotate the player based on the input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
