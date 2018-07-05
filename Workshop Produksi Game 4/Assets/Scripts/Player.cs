using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float speed = 3f;
    private Animator anim;
    private Vector3 target;
	
	void Start () {
        target = transform.position;
        anim = GetComponent<Animator>();
	}
	
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;

            if (target.x > transform.position.x)
            {
                anim.Play("Walk_Right");
            }
            else if (target.x < transform.position.x)
            {
                anim.Play("Walk_Left");
            }

            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        else if(Input.GetMouseButtonUp(0))
        {
            anim.Play("Idle");
        }
    }
}