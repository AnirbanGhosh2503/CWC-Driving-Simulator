using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1; // e.g., Follow Cam
    public Camera camera2; // e.g., Top Down Cam

    void Start()
    {
        // Make sure only one camera is active at the start
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Toggle cameras
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }
    }
}
