using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    public float zoomSensitivity = 10f;
    public float moveSensitivity = 0.5f;

    void Update()
    {
        // Zoom with mouse wheel
        float zoomAmount = Input.GetAxis("Mouse ScrollWheel") * zoomSensitivity;
        Camera.main.fieldOfView -= zoomAmount; // For a perspective camera
        // Camera.main.orthographicSize -= zoomAmount; // For an orthographic camera

        // Panning with Ctrl + Left Mouse Button
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetMouseButton(0))
        {
            float moveX = Input.GetAxis("Mouse X") * moveSensitivity;
            float moveY = Input.GetAxis("Mouse Y") * moveSensitivity;
            transform.Translate(-moveX, -moveY, 0);
        }

        // Clamp values if necessary
        // ...
    }
}
