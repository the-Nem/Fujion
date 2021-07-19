using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuZalooping : MonoBehaviour
{
    public float backGroundSpeed = 0.1f;
    public Renderer backRenerer;
    void Update()
    {
        BackMove();
    }

    private void BackMove()
    {
        backRenerer.material.mainTextureOffset += new Vector2(backGroundSpeed * Time.deltaTime, 0f);
    }
}
