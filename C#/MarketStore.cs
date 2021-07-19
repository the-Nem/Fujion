using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MarketStore : MonoBehaviour
{
    //public Saver save;


    public static MarketStore instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }

    }
    private int realSkin_1Cost = 800;
    public int Skin_1Cost
    {
        get { return realSkin_1Cost; }
  
    }
    public TMP_Text Skin_1Text;


    private int realSkin_2Cost = 500;
    public int Skin_2Cost
    {
        get { return realSkin_2Cost; }

    }
    public TMP_Text Skin_2Text;






    public int newLifeQuantity = 1;
    public int realLifeCost = 30;
    public int LifeCost
    {
        get { return realLifeCost; }

    }
    public TMP_Text LifeCostText;
    public TMP_Text PuchasedLifeQuantity;



    //about Shiled
    public int ShiledQuantity = 1;

    public int realShiledCost = 20;
    public int ShiledCost
    {
        get { return realShiledCost; }

    }
    public TMP_Text ShiledCostText;
    public TMP_Text PuchasedShieldQuantity;





    public bool boolSlowdown;
    public int SlowdownQuantity = 1;
    public int realSlowdownCost = 15;
    public int SlowdownCost
    {
        get { return realSlowdownCost; }

    }

    public TMP_Text SlowdownCostText;
    public TMP_Text PuchasedSlowdQuantity;

    void Start()
    {
    }

    void Update()
    {

        Skin_2Text.text = Skin_2Cost.ToString();
        LifeCostText.text = LifeCost.ToString();
        ShiledCostText.text = ShiledCost.ToString();
        SlowdownCostText.text = SlowdownCost.ToString();



        PuchasedLifeQuantity.text = newLifeQuantity.ToString();
        PuchasedShieldQuantity.text = ShiledQuantity.ToString();
        PuchasedSlowdQuantity.text = SlowdownQuantity.ToString();

        // move this from update to new method and make it under while


    }

    public void BuyObjPack1()
    {
        if ( The_Score.instance.Coin_score_MAIN< Skin_1Cost) { return;  }
        The_Score.instance.CoinCalculation(-Skin_1Cost);
        GeneralGameObj.instance.SetNumbernumberSwich(1);
    }
    public void BuyObjPack_2()
    {
        if (The_Score.instance.Coin_score_MAIN < Skin_2Cost) { return; }
        The_Score.instance.CoinCalculation(-Skin_2Cost);
        GeneralGameObj.instance.SetNumbernumberSwich(2);
    }

    public void BuyLife()
    {
        if (The_Score.instance.Coin_score_MAIN < LifeCost) { return; }
        The_Score.instance.CoinCalculation(-LifeCost);
        newLifeQuantity++;
    }
    public void BuyShild()
    {
        if (The_Score.instance.Coin_score_MAIN < ShiledCost) { return; }
        The_Score.instance.CoinCalculation(-ShiledCost);
        ShiledQuantity++;
    }
    public void BuySlowDown()
    {
        if (The_Score.instance.Coin_score_MAIN < SlowdownCost) { return; }
        The_Score.instance.CoinCalculation(-SlowdownCost);
        SlowdownQuantity++;
    }

}
