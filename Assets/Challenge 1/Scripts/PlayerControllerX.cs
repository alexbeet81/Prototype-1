using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    public InputAction MoveAction;

    private Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // get the user's vertical input
        moveInput = MoveAction.ReadValue<Vector2>();

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * moveInput.y);
    }
}
