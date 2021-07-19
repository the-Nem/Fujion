using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bonus : MonoBehaviour
{
    public static Bonus instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) { boolShiledStatus = !boolShiledStatus; }
    }

    public bool boolShiledStatus;
    private float shiledAndSlowTime = 10f;
    private float everyHowmuchSeconds = 1f;

    public GameObject OnScreenShildStatus;
    public GameObject AboutShield;
    public TMP_Text shiledAndSlowTime_status;

    public void UseLife()
    {
        //if (MarketStore.instance.newLifeQuantity < 1) { return; }
        //if(LifeManagment.instance.lifes_score == 3) { return; }

        if (MarketStore.instance.newLifeQuantity < 1 | LifeManagment.instance.lifes_score == 3)
        {
            return;
        }
        AudioManagment.instance.UseSomeBonus();
        LifeManagment.instance.LiveManipulations(+1);
        MarketStore.instance.newLifeQuantity--;

    }
    public void UseShiled()
    {

        if (MarketStore.instance.ShiledQuantity < 1) { return; }
        AudioManagment.instance.UseSomeBonus();
        boolShiledStatus = true;
        StartCoroutine(iCounForShiled());
        OnScreenShildStatus.SetActive(true);
        AboutShield.SetActive(true);
        MarketStore.instance.ShiledQuantity--;
    }
    private IEnumerator iCounForShiled()
    {
        while (shiledAndSlowTime > 0)
        {
            yield return new WaitForSeconds(everyHowmuchSeconds);
            shiledAndSlowTime --;
            shiledAndSlowTime_status.text = shiledAndSlowTime.ToString(); 
        }
        boolShiledStatus = false;
        OnScreenShildStatus.SetActive(false);
        AboutShield.SetActive(false);
        shiledAndSlowTime = 10f;
    }
    public void UseSlowDown()
    {
        if (MarketStore.instance.SlowdownQuantity < 1) { return; }
        AudioManagment.instance.UseSomeBonus();
        StartCoroutine(iCounForSlowDown());
        OnScreenShildStatus.SetActive(true);
        MarketStore.instance.SlowdownQuantity--;


    }
    private IEnumerator iCounForSlowDown()
    {
        while (shiledAndSlowTime > 0)
        {
            yield return new WaitForSeconds(everyHowmuchSeconds);
            shiledAndSlowTime--;
            ZaLoopingBackGround.instance.backGroundSpeed = 0.08f;
            GroupMovment.ChangeSpeed(180f);
            shiledAndSlowTime_status.text = shiledAndSlowTime.ToString();

        }
        ZaLoopingBackGround.instance.backGroundSpeed = 0.1f;
        GroupMovment.ChangeSpeed(200f);
        OnScreenShildStatus.SetActive(false);
        shiledAndSlowTime = 10f;
    }

}
