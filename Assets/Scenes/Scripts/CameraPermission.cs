using UnityEngine;
using UnityEngine.Android;

public class CameraPermissionRequest : MonoBehaviour
{
    void Start()
    {
        // Check if the application already has permission
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            // Request camera permission
            Permission.RequestUserPermission(Permission.Camera);
        }
        else
        {
            // Camera permission already granted, you can start AR functionality here
        }
    }

    void Update()
    {
        // Optionally, handle cases where permission is granted after the initial request
        if (Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            // You can start AR functionality here once permission is granted
        }
    }
}
