using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TestScript : MonoBehaviour
{
    public XRNode inputSource;
    public UnityEngine.XR.Interaction.Toolkit.InputHelpers.Button inputButton;
    public float inputThreshold = 0.1f;
    public Transform movementSource;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start"); //sirve
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.XR.Interaction.Toolkit.InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(inputSource),inputButton,out bool isPressed, inputThreshold);

        if (isPressed) {
            Debug.Log("Right Trigger Button is being pressed"); //no sirve
        }

    }
}
