using UnityEngine;
using Microsoft.Maps.Unity;
using Microsoft.Geospatial;

public class MapMarker : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 is the left mouse button
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform) // Check if the hit object is this marker
                {
                    OnMarkerClicked();
                }
            }
        }
    }

    private void OnMarkerClicked()
    {
        // Handle the click event, e.g., display information
        Debug.Log("Marker clicked: " + gameObject.name);
        menuPanel.SetActive(true);
    }

}
