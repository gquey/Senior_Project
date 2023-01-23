using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class zoom : MonoBehaviour {

    public Camera mainCamera;
    public float defaultFOV = 90;

    void start() {
        mainCamera = gameObject.GetComponent<Camera>();
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.Z))
        {
            mainCamera.fieldOfView = (defaultFOV / 2);
        }
        else if (mainCamera.fieldOfView != defaultFOV)
        {
            mainCamera.fieldOfView = (defaultFOV);
        }
    }
}