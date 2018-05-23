using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : SimpleBlit {
    bool starting = false;

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            starting = true;
        }
        if(starting)
        {
            StartCoroutine(startTransition());
        }
        
    }
    
}
