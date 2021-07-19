using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroupMovment : MonoBehaviour
{

    //private float inputX;
    [SerializeField] private Rigidbody2D rb;
    //[SerializeField] private float speed = 200f;
    private float speed;
    private float constantAcceleration=5f;
    private float comphySpeed=240f;
    private int acticeScene;

    public bool IsOkToJump;

    private void Awake()
    {
        acticeScene = SceneManager.GetActiveScene().buildIndex;
        speed = comphySpeed + (acticeScene* constantAcceleration);
    }

    private void FixedUpdate()
    {
         if(GameManager.gameStatus == false) { return; }          //!! !! unComment this
        Movement();
        if (IsOkToJump) { TallJump(); }
    }

    private void Movement()
    {
        rb.velocity = transform.right * speed * Time.fixedDeltaTime;        
    }
    public static void ChangeSpeed(float speed)
    {
        speed = speed;
    }
    public void TallJump()
    {
        //rb.AddForce(transform.up * 9000f*Time.fixedDeltaTime);
        //rb.AddForce(transform.up* speed * Time.fixedDeltaTime);
        rb.AddForce(new Vector3(transform.position.x,transform.position.y * 9999f*Time.fixedDeltaTime, 0));
    }
    public void JmpBool(bool onOff) { IsOkToJump = onOff; }
    //public void JmpBool2() {  IsOkToJump=!IsOkToJump; }
}

