using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoints : MonoBehaviour
{
    public GameObject Coint;

    private float heightfireAxis = 3f;
    private float heightwaterAxis = -3f;

   // public int counterSpawnedcandys;

    private void Awake()
    {
        GiveMeSomeCoints_Fire();
        GiveMeSomeCoints_Water();
    }


    private void GiveMeSomeCoints_Fire()
    {

        for (float i = 1; i < 7; i++)
        {
            float posX = 48f;

            //Instantiate(Coint, new Vector3(posX*i, heightfireAxis, 0), Quaternion.identity);
            Instantiate(Coint, new Vector3(posX * i, heightfireAxis, 0), new Quaternion(90,90,90,0));
            //counterSpawnedcandys++;
        }

    }
    private void GiveMeSomeCoints_Water()
    {
        for (float i = 1; i < 10; i++)
        {
            float posX = 36f;

            //Instantiate(Coint, new Vector3(posX * i, heightwaterAxis, 0), Quaternion.identity);
            Instantiate(Coint, new Vector3(posX * i, heightwaterAxis, 0), new Quaternion(90, 90, 90, 0));
            //counterSpawnedcandys++;
        }
    }

}
