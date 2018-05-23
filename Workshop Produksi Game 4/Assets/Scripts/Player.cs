using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float speed = 3f;
    private Rigidbody2D rb;
    Animator anim;
	
    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(x * speed, y * speed);

        if (rb.velocity.x > 0)
            anim.Play("Walk_Right");
        else if (rb.velocity.x < 0)
            anim.Play("Walk_Left");
        else if (rb.velocity.y > 0)
            anim.Play("Walk_Right");
        else if (rb.velocity.y < 0)
            anim.Play("Walk_Left");
        else if (rb.velocity.y == 0)
            anim.Play("Idle");
	}
}