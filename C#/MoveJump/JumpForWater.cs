using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this is for lower player

public class JumpForWater : MonoBehaviour
{
    public static JumpForWater instance;
    public bool IsItOKtoJumpWater;



    public float gravity = 300f;

    public float groundForce = 1f;
    public float xPower = 6;


    public Vector2 velocityVec;
    public float jumpVelocity = -38f;
    public float groundHeight = -1f;
    public bool isGrounded = false;
    public bool isHoldingJump = false;
    public float maxHoldJumpTime = 0.4f;
    public float holdJumpTimer = 0.0f;
    //public float jumpGroundThreshold = -2f;
    public float jumpGroundThreshold = -5f;
    float groundDistance;

    private void Awake()
    {
        if (instance == null) { instance = this; }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        groundDistance = Mathf.Abs(pos.y - groundHeight);

        JumpMethod();
    }
    public void JumpMethod()
    {
        if (isGrounded || groundDistance >= jumpGroundThreshold)
        {
            if (IsItOKtoJumpWater)
            {
                isGrounded = false;
                velocityVec.y = jumpVelocity;
                velocityVec.x = xPower;
                isHoldingJump = true;
                holdJumpTimer = 0;
            }
        }
        if (IsItOKtoJumpWater)
        {
            isHoldingJump = false;
        }
    }
        private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        if (!isGrounded)
        {
            if (isHoldingJump)
            {
                holdJumpTimer += Time.fixedDeltaTime;
                if (holdJumpTimer >= maxHoldJumpTime)
                {
                    isHoldingJump = false;
                }
            }


            pos.y += velocityVec.y * Time.fixedDeltaTime;
            pos.x += velocityVec.x * Time.fixedDeltaTime;
            if (!isHoldingJump)
            {
                velocityVec.y += gravity * Time.fixedDeltaTime;

            }
            if (pos.y >= groundHeight)
            {
                pos.y = groundHeight;
                isGrounded = true;
                //holdJumpTimer = 0;
            }
        }

        transform.position = pos;

    }
    public void JumpBool() { IsItOKtoJumpWater = !IsItOKtoJumpWater; }

}
