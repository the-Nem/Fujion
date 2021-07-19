using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JumpForFire : MonoBehaviour
{
    public static JumpForFire instance;
    public bool IsItOKtoJumpFire;



    public int number;
    public Rigidbody2D rb;
    //private float _jumpForse = 100f;

    //public Button ButtonJump;
    //public GameObject ButtonJump2;

    public float gravity = -300f;

    public float groundForce = 1f;
    public float xPower = 6;



    public Vector2 velocityVec;
    public float jumpVelocity = 38f;
    public float groundHeight = 1f;
    public bool isGrounded = false;
    public bool isHoldingJump = false;
    public float maxHoldJumpTime = 0.4f;
    public float holdJumpTimer = 0.0f;
    public float jumpGroundThreshold = 5f;
    float groundDistance;


    //private bool test;


   // public bool JumpbFuckingBool;



    private void Awake()
    {
        if (instance == null) { instance = this; }
        //GameObject.Find("ButtonJump").GetComponent<Button>().onClick.AddListener(JumpBool);
    }
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameStatus == false) { return; }
        Vector2 pos = transform.position;
        groundDistance = Mathf.Abs(pos.y - groundHeight);

        TryToJump();
    }

    public void TryToJump()
    {
        if (isGrounded || groundDistance <= jumpGroundThreshold)
        {
            if (IsItOKtoJumpFire)
            {
                isGrounded = false;
                velocityVec.y = jumpVelocity;
                velocityVec.x = xPower;
                isHoldingJump = true;
                holdJumpTimer = 0;
            }
        }
        if (IsItOKtoJumpFire)
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
                //velocityVec.x += groundForce * Time.fixedDeltaTime;  //this my be problem

            }
            if (pos.y <= groundHeight)
            {
                pos.y = groundHeight;
                isGrounded = true;
                //holdJumpTimer = 0;
            }
        }

        transform.position = pos;

    }

    public void JumpBool() { IsItOKtoJumpFire =!IsItOKtoJumpFire;  }
}
