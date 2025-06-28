using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightExample : MonoBehaviour
{
    public Light myLight;
    void Start()
    {
        myLight.color = Color.gray;
        myLight.intensity = 2.0f;
    }
}
