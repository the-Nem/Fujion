using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSc : MonoBehaviour
{

    public GameObject Column;
    private Vector3 posColumn;
    private int _columnQuantity = 15;
    float distance1 = 20f;

    float _posYfire = 0.5f;
    float _posYWater = -5f;

    private void Awake()
    {
        CreateBackGround();
    }

    private void CreateBackGround()
    {
        for (float i = 0; i < _columnQuantity; i++)
        {
            float distance = distance1 * i;
            Instantiate(Column, new Vector3(distance, _posYfire, 0), Quaternion.identity);
        }
        for (float i = 0.5f; i < _columnQuantity; i++)
        {
            float distance = distance1 * i;
            Instantiate(Column, new Vector3(distance, _posYWater, 0), Quaternion.identity);
        }
    }


}
