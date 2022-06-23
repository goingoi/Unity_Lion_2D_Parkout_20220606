/*using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;
using System;

public class frogController : MonoBehaviour
{
    // Start is called before the first frame update





    #region 資料:保存系統需要的資料
    Rigidbody2D rb;
    float volecity;
    [SerializeField, Header("地板"), Tooltip("這是地板標籤")] private LayerMask ground;
    Animator anim;
    [SerializeField, Range(1, 3)] int JumpCount;
    bool jumpPress, isGround;
    #endregion
    #region 功能:實作該系統的複雜方法

    #endregion


    #region 事件:程式入口

    #endregion
    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    //播放遊戲時執行一次
    void Start()
    {

        JumpCount = 2;
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        Jump();
    }
    void Update()
    {
        isGround = Physics2D.OverlapCircle(transform.GetChild(0).position, 0.1f, ground);
        if (isGround) JumpCount = 2;
        if (Input.GetButtonDown("Jump") && JumpCount > 0) jumpPress = true;
        Movement();
        SwAnim();

    }
    void Movement()
    {
        volecity = Input.GetAxis("Horizontal");
        if (volecity > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (volecity < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        rb.velocity = new Vector2(volecity * 5, rb.velocity.y);
    }
    void SwAnim()
    {
        anim.SetFloat("run", Math.Abs(volecity));
        anim.SetFloat("jump", rb.velocity.y);
        anim.SetInteger("jumpCount", JumpCount);
    }
    void Jump()
    {

        if (jumpPress && JumpCount > 0)
        {
            JumpCount--;
            rb.velocity = new Vector2(rb.velocity.x, 5);
            jumpPress = false;
        }
    }
}
