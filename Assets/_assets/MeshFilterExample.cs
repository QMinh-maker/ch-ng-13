using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshFilterExample : MonoBehaviour
{
    public MeshFilter myMeshFilter;
    public Mesh mesh;
    void Start()
    {
        myMeshFilter.mesh = mesh;
    }   
}
