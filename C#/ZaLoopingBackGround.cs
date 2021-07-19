using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaLoopingBackGround : MonoBehaviour
{
    public static ZaLoopingBackGround instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
    }

    public float backGroundSpeed =0.1f;
    public Renderer backRenerer;
    void Update()
    {
        if (GameManager.gameStatus == false) { return; }

        BackMove();        
    }

    private void BackMove()
    {
        backRenerer.material.mainTextureOffset += new Vector2(backGroundSpeed*Time.deltaTime,0f);
    }
}
