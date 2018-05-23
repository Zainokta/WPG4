using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricObject : MonoBehaviour {

    private const int isometricRangePerYUnit = 100;
    
    public Transform target;
    
    public int targetOffset = 0;

    void Update()
    {
        if (target == null)
            target = transform;
        Renderer renderer = GetComponent<Renderer>();
        renderer.sortingOrder = (int)(target.position.y * isometricRangePerYUnit) + targetOffset;
    }
}
