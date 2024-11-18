using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera thirdPersonCamera;   // Camera above and behind the vehicle
    public Camera firstPersonCamera;   // Camera from the driver's seat
    public KeyCode switchKey = KeyCode.C;  // Key to switch camera views

    void Start()
    {
        // Ensure only the third-person camera is active at the start
        thirdPersonCamera.enabled = true;
        firstPersonCamera.enabled = false;
    }

    void Update()
    {
        // Check if the switch key is pressed
        if (Input.GetKeyDown(switchKey))
        {
            // Toggle the cameras
            thirdPersonCamera.enabled = !thirdPersonCamera.enabled;
            firstPersonCamera.enabled = !firstPersonCamera.enabled;
        }
    }
}
