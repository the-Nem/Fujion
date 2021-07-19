using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fix : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {       //reset values & saves

            The_Score.instance.Coin_score_MAIN = 0;
            MarketStore.instance.newLifeQuantity = 1;
            MarketStore.instance.ShiledQuantity = 1;
            MarketStore.instance.SlowdownQuantity = 1;
            Scene_Management.instance.finishedLvls = 1;

        }
    }
}
