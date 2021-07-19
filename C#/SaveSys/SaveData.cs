using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    [System.Serializable]
    public class SaveData 
    {

        public int Coin_score_MAIN;
        public int newLifeQuantity;
        public int ShiledQuantity;
        public int SlowdownQuantity;
        public int finishedLvls;


        public SaveData(CollectValues player)
        {

            Coin_score_MAIN = player.Coin_score_MAIN;
            newLifeQuantity = player.newLifeQuantity;
            ShiledQuantity = player.ShiledQuantity;
            SlowdownQuantity = player.SlowdownQuantity;
            finishedLvls = player.finishedLvls;

        }
    }
}
