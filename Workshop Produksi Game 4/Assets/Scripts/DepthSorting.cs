using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthSorting : MonoBehaviour {

    private const int isometricRangePerYUnit = 100;

    public int offset;

    void Update()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.sortingOrder = (int)(transform.position.y * isometricRangePerYUnit) + offset;
    }
}
