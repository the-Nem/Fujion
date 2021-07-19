using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    private int _test;



    public static SavePrefs instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        LoadData();

    }


    public void SaveData()
    {
        PlayerPrefs.SetInt("Coins", The_Score.instance.Coin_score_MAIN);
        PlayerPrefs.SetInt("newLifeQuantity", MarketStore.instance.newLifeQuantity);
        PlayerPrefs.SetInt("ShiledQuantity", MarketStore.instance.ShiledQuantity);
        PlayerPrefs.SetInt("SlowdownQuantity", MarketStore.instance.SlowdownQuantity);
        PlayerPrefs.SetInt("finishedLvls", Scene_Management.instance.finishedLvls);

    }
    public void LoadData()
    {
        The_Score.instance.Coin_score_MAIN = PlayerPrefs.GetInt("Coins",0);
        MarketStore.instance.newLifeQuantity = PlayerPrefs.GetInt("newLifeQuantity",1);
        MarketStore.instance.ShiledQuantity = PlayerPrefs.GetInt("ShiledQuantity", 1);
        MarketStore.instance.SlowdownQuantity = PlayerPrefs.GetInt("SlowdownQuantity", 1);
        Scene_Management.instance.finishedLvls = PlayerPrefs.GetInt("finishedLvls", 1);
    }
    private void OnApplicationQuit()
    {
        SaveData();
    }
}
