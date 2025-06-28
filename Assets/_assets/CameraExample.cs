using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraExample : MonoBehaviour
{
    public Camera mainCamera;
    void Start()
    {
        mainCamera.backgroundColor = Color.blue;
    }   
}
