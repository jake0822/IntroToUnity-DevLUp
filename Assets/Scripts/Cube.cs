using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public GameObject cube;
    public float offset;
    public int x, y;
    
    private BoxCollider _collider;
    private float _length;
    void Start()
    {
        _collider = GetComponent<BoxCollider>();
        _length = _collider.size.x;

        for (int i = 0; i <= x; i++)
        {
            Instantiate(cube, transform);
        }
    }

}
