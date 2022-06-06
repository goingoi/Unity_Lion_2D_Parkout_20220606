using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class frogController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    float volecity;
    Transform isGround;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        Movement();
        SwAnim();
        Jump();
    }
    void Movement()
    {
        if(volecity>0)
        {
            transform.localScale=new Vector3(1,1,1);
        }else if(volecity<0){
            transform.localScale=new Vector3(-1,1,1);
        }
        volecity = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(volecity * 5, rb.velocity.y);
    }
    void SwAnim(){
        anim.SetFloat("run",Math.Abs(volecity));
    }
    void Jump(){
        if(Input.GetButtonDown("Jump")){
            rb.velocity = new Vector2(rb.velocity.x,5);
        }
    }
}
