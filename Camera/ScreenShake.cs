using UnityEngine;
using Unity.Cinemachine;
using UnityEngine.InputSystem;

public class ScreenShake : MonoBehaviour
{
    public static ScreenShake Instance { get; private set; }


    private CinemachineImpulseSource cinemachineImpulseSource;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more than one ScreenShake! " + transform + "-" + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;

        cinemachineImpulseSource = GetComponent<CinemachineImpulseSource>();
    }

    private void Update()
    {
        /* ´ú¸Õ¥\¯à
        if (Keyboard.current.tKey.wasPressedThisFrame)
        {
            cinemachineImpulseSource.GenerateImpulse();
        }
        */
    }

    public void Shake(float intensity = 1f)
    { 
        cinemachineImpulseSource.GenerateImpulse(intensity);
    }

}
