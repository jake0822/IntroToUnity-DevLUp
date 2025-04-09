using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    private Material mat;
    private BoxCollider collider;
    private MeshRenderer mesh;
    public bool flashTheCube = false;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
        collider = GetComponent<BoxCollider>();
        mesh = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        if (flashTheCube)
        {
            mat.color = new Color(1, 1, 1, mat.color.a - 0.01f);
            if (mat.color.a <= 0)
            {
                flashTheCube = false;
                collider.enabled = false;
                mesh.enabled = false;
                StartCoroutine(resetCube());
            }
        }
    }

    public void flashCube()
    {
        flashTheCube = true;
    }

    IEnumerator resetCube()
    {
        yield return new WaitForSeconds(2);
        collider.enabled = true;
        mat.color = new Color(1, 1, 1, 1);
        mesh.enabled = true;
    }
}
