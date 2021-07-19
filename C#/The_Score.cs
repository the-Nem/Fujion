using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class The_Score : MonoBehaviour
{


    public static The_Score instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
        DontDestroyOnLoad(gameObject);
    }

    private int realCoin=0;

    public int Coin_score_MAIN 
    {
        get { return realCoin; }
        set
        {   
            //if (value>800) { GameManager.gameStatus = false; return; }
            //else { realCoin = value; }

             realCoin = value; 
        }
    }
    public TMP_Text scoreOnScreenInGame;
    public TMP_Text scoreOnScreenInMarket;




    void Start()
    {
        Coin_score_MAIN = PlayerPrefs.GetInt("Coins", 0);

    }

    void Update()
    {

        HowMuchMoneyDoYouHave();
        if (Input.GetKeyDown(KeyCode.C)) { CoinCalculation(100); }
    }

    private void HowMuchMoneyDoYouHave()
    {

        //scoreOnScreenInGame.text = Coin_score_MAIN.ToString();
        scoreOnScreenInGame.text = Coin_score_MAIN.ToString();
        //scoreOnScreenInMarket.text = Coin_score_MAIN.ToString();
        scoreOnScreenInMarket.text = Coin_score_MAIN.ToString();
    }

    public void CoinCalculation(int value) { Coin_score_MAIN += value; }  //Saver.instance.jsonCandyScore += candy; Saver.instance.Save();
    public void SimpleCoinCalculation() 
    {
        Coin_score_MAIN = Coin_score_MAIN*2;

    } 



}
