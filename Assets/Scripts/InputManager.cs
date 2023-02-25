using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static Action<Vector3> OnMoveInput;
    
    private TouchInput _touchInput;
    private Camera _camera;

    private InputAction _pressAction;
    private InputAction _pressPositionAction;

    private void Awake()
    {
        _camera = Camera.main;
        _touchInput = new TouchInput();
        _touchInput.Enable();
        _pressAction = _touchInput.Touch.TouchPress;
        _pressPositionAction = _touchInput.Touch.TouchPosition;
    }

    private void OnEnable()
    {
        _pressAction.started += OnPress;
    }

    private void OnDisable()
    {
        _pressAction.started -= OnPress;
    }

    private void OnPress(InputAction.CallbackContext context)
    {
        var position = _pressPositionAction.ReadValue<Vector2>();
        Ray ray = _camera.ScreenPointToRay(position);

        RaycastHit2D hit2D = Physics2D.GetRayIntersection(ray);
        if (!hit2D.collider.gameObject.CompareTag("NotWalkable"))
        {
            var worldPosition = _camera.ScreenToWorldPoint(position);
            worldPosition.z = 0;
            OnMoveInput?.Invoke(worldPosition);
        }
    }
}
