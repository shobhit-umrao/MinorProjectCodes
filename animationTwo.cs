using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class animationTwo : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject controllerRotate;
    public Animator buildingRotate;
    // Start is called before the first frame update
    void Start()
    {
        controllerRotate = GameObject.Find("VirtualButtonRotate");
        controllerRotate.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        buildingRotate.GetComponent<Animator>();

    }
    public void OnButtonPressed(VirtualButtonBehaviour Rotate_virtual_button)
    {
        buildingRotate.Play("animation_rotate");
        Debug.Log("Rotate Button Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour Rotate_virtual_button)
    {
        buildingRotate.Play("none");
        Debug.Log("Rotate Button Released");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
