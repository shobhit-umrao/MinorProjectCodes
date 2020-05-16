using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class animationOne : MonoBehaviour, IVirtualButtonEventHandler 
{
    public GameObject controllerZoom;
    public Animator buildingZoom;
    // Start is called before the first frame update
    void Start()
    {
        controllerZoom = GameObject.Find("VirtualButtonZoom");
        controllerZoom.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        buildingZoom.GetComponent<Animator>();

    }
    public void OnButtonPressed(VirtualButtonBehaviour Zoom_virtual_button)
    {
        buildingZoom.Play("animation_zoom");
        Debug.Log("Zoom Button Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour Zoom_virtual_button)
    {
        buildingZoom.Play("none");
        Debug.Log("Zoom Button Released");

    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
