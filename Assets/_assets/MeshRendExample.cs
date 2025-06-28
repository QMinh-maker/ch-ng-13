using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendExample : MonoBehaviour
{
    public MeshRenderer myMeshRenderer;
    void Start()
    {
        myMeshRenderer.material.color = Color.green;
    }

    
}
