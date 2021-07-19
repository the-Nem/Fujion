using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongryBerry
{
    public class CollectValues : MonoBehaviour
    {
        The_Score ts = new The_Score();

        public int Coin_score_MAIN;
        public int newLifeQuantity;
        public int ShiledQuantity;
        public int SlowdownQuantity;
        public int finishedLvls;

        public static CollectValues instance;
        private void Awake()
        {
            if (instance == null) { instance = this; }
        }
        private void Start()
        {

            LoadPayerData();
            SetData();
            //BornCandies.instance.CheckForFood();

        }
        public void Update()
        {
            //coins = The_Score.instance.Coin_score_MAIN;  /// ?!?!?!?!!??!


            //Debug.Log("coins in saver = " + coins);
            //Debug.Log("coins in game = " + ts.Coin_score_MAIN);



            if (Input.GetKeyDown(KeyCode.S)) 
            {
                GetData();
                SavePlayerData();

            }
            if (Input.GetKeyDown(KeyCode.L)) 
            { 
                LoadPayerData();
                SetData();
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                The_Score.instance.Coin_score_MAIN = 0;
                MarketStore.instance.newLifeQuantity = 1;
                MarketStore.instance.ShiledQuantity = 1;
                MarketStore.instance.SlowdownQuantity = 1;
                Scene_Management.instance.finishedLvls = 1;
                //BornCandies.instance.MeatStatus = 0;
                SavePlayerData();

            }
        }


        public void SavePlayerData()
        {
            SaverBase.SaveValues(this);
        }

        public void LoadPayerData()
        {
            SaveData data = SaverBase.LoadPlayer();
            Coin_score_MAIN = data.Coin_score_MAIN;
            newLifeQuantity = data.newLifeQuantity;
            ShiledQuantity = data.ShiledQuantity;
            SlowdownQuantity = data.SlowdownQuantity;
            finishedLvls = data.finishedLvls;
            //MeatStatus = data.MeatStatus;
        }

        public void GetData()
        {
            //coins = ts.Coin_score_MAIN;
            Coin_score_MAIN = The_Score.instance.Coin_score_MAIN;
            newLifeQuantity = MarketStore.instance.newLifeQuantity;
            ShiledQuantity = MarketStore.instance.ShiledQuantity;
            SlowdownQuantity = MarketStore.instance.SlowdownQuantity;
            finishedLvls = Scene_Management.instance.finishedLvls;
            //MeatStatus = BornCandies.instance.MeatStatus;


        }
        private void SetData()
        {
            The_Score.instance.Coin_score_MAIN = Coin_score_MAIN;
            MarketStore.instance.newLifeQuantity = newLifeQuantity;
            MarketStore.instance.ShiledQuantity = ShiledQuantity;
            MarketStore.instance.SlowdownQuantity = SlowdownQuantity;
            Scene_Management.instance.finishedLvls = finishedLvls;
            //BornCandies.instance.MeatStatus = MeatStatus;
        }

        private void OnDestroy() { SavePlayerData(); }
        private void OnApplicationQuit() { SavePlayerData(); }

    }
}
