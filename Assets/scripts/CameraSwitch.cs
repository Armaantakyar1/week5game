using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    private bool usingCamera1 = true;

    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            usingCamera1 = !usingCamera1;
            camera1.enabled = usingCamera1;
            camera2.enabled = !usingCamera1;
        }
    }
}
