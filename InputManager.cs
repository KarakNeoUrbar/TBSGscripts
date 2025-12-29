
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    
    [SerializeField] private float HandleMoveSpeed;

    private PlayerInputActions playerInputActions;

    public static InputManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more than one InputManager! " + transform + "-" + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    public Vector2 GetMouseScreenPosition()
    {
        return Mouse.current.position.ReadValue();
    }

    public bool IsMouseButtonDownThisFrame()
    {
        return playerInputActions.Player.Click.WasPressedThisFrame();
        //µw¼g return Mouse.current.leftButton.wasPressedThisFrame;
    }

    public Vector2 GetCameraMoveVector()
    {
        return playerInputActions.Player.CameraMovement.ReadValue<Vector2>() * HandleMoveSpeed;

        /* µw¼g¼gªk¯d¦s
        Vector2 inputMoveDir = new Vector2(0, 0);
        if (Keyboard.current.wKey.isPressed)
        {
            inputMoveDir.y = +HandleMoveSpeed;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            inputMoveDir.y = -HandleMoveSpeed;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            inputMoveDir.x = -HandleMoveSpeed;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            inputMoveDir.x = +HandleMoveSpeed;
        }

        return inputMoveDir;
        */

    }

    public float GetCameraRotateAmount()
    {
        float RTinput = playerInputActions.Player.CameraRotate.ReadValue<float>();
        return RTinput * HandleMoveSpeed;
        /* µw¼g¼gªk¯d¦s
        float rotateAmount = 0f;

        if (Keyboard.current.qKey.isPressed)
        {
            rotateAmount = +HandleMoveSpeed;
        }
        if (Keyboard.current.eKey.isPressed)
        {
            rotateAmount = -HandleMoveSpeed;
        }
        return rotateAmount;
        */
    }

    public float GetCameraZoomAmount()
    {
        return playerInputActions.Player.CameraZoom.ReadValue<float>();

        /* µw¼g¼gªk¯d¦s
        float zoomAmount = 0f;
        if (Mouse.current.scroll.ReadValue().y > 0)
        {
            zoomAmount = -1f;
        }
        if (Mouse.current.scroll.ReadValue().y < 0)
        {
            zoomAmount = +1f;
        }
        return zoomAmount;
        */

    }


}
