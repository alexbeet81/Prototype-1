using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public Camera view1;
    public Camera view2;

    public InputAction SwitchViewAction;

    private void OnEnable()
    {
        SwitchViewAction.Enable();
    }

    private void OnDisable()
    {
        SwitchViewAction.Disable();
    }
    private void Start()
    {
        view1.gameObject.SetActive(true);
        view2.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (SwitchViewAction.WasPressedThisFrame())
        {
            ToggleView();
        }
        
    }

    private void ToggleView()
    {
        view1.gameObject.SetActive(!view1.gameObject.activeSelf);
        view2.gameObject.SetActive(!view2.gameObject.activeSelf);     
    }
}
