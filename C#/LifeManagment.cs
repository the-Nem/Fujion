using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManagment : MonoBehaviour
{
    public static LifeManagment instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
    }
    public GameObject Life_3;
    public GameObject Life_2;
    public GameObject Life_1;
    private int realLife = 3;
    public int lifes_score
    {
        get { return realLife; }
        set
        {
            if (value > 3) { GameManager.gameStatus = false; return; }
            else { realLife = value; }
        }
    }
    void Update()
    {
        InGameLifeCount();
        CheckIfAlive();
    }
    private void CheckIfAlive()
    {
        if (lifes_score > 0) { return; }
        if (lifes_score == 0)
        {
            GameManager.gameStatus = false;
            UIElements.instance.PanelGameOver.SetActive(true);
        }
    }
    public void InGameLifeCount()
    {
        if (lifes_score == 0) { return; }
        else if (lifes_score == 2) { Life_3.gameObject.SetActive(false); }
        else if (lifes_score == 1) { Life_2.transform.gameObject.SetActive(false); }
        else if (lifes_score == 0) { Life_1.transform.gameObject.SetActive(false); }
    }
    public void LiveManipulations(int life) {   lifes_score += life; }
}
