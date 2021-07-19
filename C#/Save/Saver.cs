using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Saver : MonoBehaviour
{
    //    public int JsonCoins { get { return JsonCoins; } private set {  } }
    //    public int jsonQuantityLife { get; private set; }
    //    public int jsonQuantityShield { get; private set; }
    //    public int jsonQuantitySlow { get; private set; }
    //    public string data { get; private set; }


    public int JsonCoins;
    public int jsonQuantityLife;
    public int jsonQuantityShield;
    public int jsonQuantitySlow;

    public int jsonQuantityOfFinishedLvls = 1;

    //[SerializeField]
    [Multiline(20)]
    public string data;

    //private void Awake()
    //{
    //    Load();   //not working
    //}
    private void Start()
    {
        Load(); //working
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {       //reset values & saves

            The_Score.instance.Coin_score_MAIN = 0;
            MarketStore.instance.newLifeQuantity = 1;
            MarketStore.instance.ShiledQuantity = 1;
            MarketStore.instance.SlowdownQuantity = 1;
            Scene_Management.instance.finishedLvls = 1;

            data = JsonUtility.ToJson(this, true);  //prettyPrint, bool, is making nice to see text
            File.WriteAllText(Application.dataPath + "save.txt", data);// this works
        }
        if (Input.GetKeyDown(KeyCode.L)) { Load(); }
        if (Input.GetKeyDown(KeyCode.S)) { Save(); }

    }

    private void CollectInfo()
    {
        JsonCoins = The_Score.instance.Coin_score_MAIN;
        jsonQuantityLife = MarketStore.instance.newLifeQuantity;
        jsonQuantityShield = MarketStore.instance.ShiledQuantity;
        jsonQuantitySlow = MarketStore.instance.SlowdownQuantity;
        jsonQuantityOfFinishedLvls = Scene_Management.instance.finishedLvls;
    }
    private void SetInfo()
    {
        The_Score.instance.Coin_score_MAIN = JsonCoins;
        MarketStore.instance.newLifeQuantity = jsonQuantityLife;
        MarketStore.instance.ShiledQuantity = jsonQuantityShield;
        MarketStore.instance.SlowdownQuantity = jsonQuantitySlow;
        Scene_Management.instance.finishedLvls = jsonQuantityOfFinishedLvls;
    }
    private void Save()
    {
        CollectInfo();
        data = JsonUtility.ToJson(this, true);  //prettyPrint, bool, is making nice to see text
        File.WriteAllText(Application.dataPath + "save.txt", data);// this works
    }
    private void Load()
    {
        data = File.ReadAllText(Application.dataPath + "save.txt");
        JsonUtility.FromJsonOverwrite(data, this);
        SetInfo();
    }

    private void OnApplicationQuit()
    {
        Save();
    }
}
