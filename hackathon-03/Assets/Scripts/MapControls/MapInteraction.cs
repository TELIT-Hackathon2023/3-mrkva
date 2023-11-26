using UnityEngine;
using Microsoft.Maps.Unity;
using Microsoft.Geospatial;
using System;

public class MapInteraction : MonoBehaviour
{
    [SerializeField] private MapRenderer mapRenderer;
    [SerializeField] private float _panningSpeed = 0.1f;

    private void Update()
    {
        // Zoom the map with the mouse scroll wheel
        float zoomChange = Input.GetAxis("Mouse ScrollWheel");
        mapRenderer.ZoomLevel = Mathf.Clamp(mapRenderer.ZoomLevel + zoomChange, mapRenderer.MinimumZoomLevel, mapRenderer.MaximumZoomLevel);

        // Panning the map with mouse drag (right mouse button)
        if (Input.GetMouseButton(1)) // Check if the right mouse button is held down
        {
            float mouseX = Input.GetAxis("Mouse X") * -1; // Invert axis
            float mouseY = Input.GetAxis("Mouse Y") * -1; // Invert axis

            // Adjust panning speed based on the zoom level
            float panningSpeed = CalculatePanningSpeed(mapRenderer.ZoomLevel);

            // Calculate new latitude and longitude based on mouse input and adjusted panning speed
            double newLatitude = mapRenderer.Center.LatitudeInDegrees + mouseY * panningSpeed;
            double newLongitude = mapRenderer.Center.LongitudeInDegrees + mouseX * panningSpeed;

            // Update the map center
            mapRenderer.Center = new LatLon(newLatitude, newLongitude);
        }
    }

    // You can adjust this function to fine-tune the panning speed for your specific use case
    float CalculatePanningSpeed(float zoomLevel)
    {
        // This is a simple example of a panning speed adjustment.
        // You may want to fine-tune this formula based on your map's scale and the desired user experience.
        return _panningSpeed / (float)Math.Pow(2, zoomLevel - 1);
    }
}
