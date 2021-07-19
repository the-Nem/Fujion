using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralGameObj : MonoBehaviour
{
    public static GeneralGameObj instance;
    public static int numberSwich;

    private Vector3 PosFrire = new Vector3(-6, 3, 0);
    private Vector3 PosWater = new Vector3(-3, -3, 0);




    public GameObject Fire_group_1;
    public GameObject Water_group_1;

    public GameObject Fire_group_2;
    public GameObject Water_group_2;

    private void Awake()
    {
        if (instance == null) { instance = this; }
        RealGObj(numberSwich);
    }
    private void Update()
    {
        //Debug.Log("numberSwich = " + numberSwich);
    }

    public void RealGObj(int caseF)
    {
        switch (numberSwich =caseF)
        {
            case 1:
                Instantiate(Fire_group_1, PosFrire, Quaternion.identity);
                Instantiate(Water_group_1, PosWater, Quaternion.identity);
                break;
            case 2:
                Instantiate(Fire_group_2, PosFrire, Quaternion.identity);
                Instantiate(Water_group_2, PosWater, Quaternion.identity);
                break;
            default:
                Instantiate(Fire_group_1, PosFrire, Quaternion.identity);
                Instantiate(Water_group_1, PosWater, Quaternion.identity);

                break;
        }
    }
    public void SetNumbernumberSwich(int i) { numberSwich = i; }





}
