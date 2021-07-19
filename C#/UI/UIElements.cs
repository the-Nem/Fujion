using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIElements : MonoBehaviour
{
    public int StatusRate;
    public GameObject PanelRateGame;


    public static UIElements instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
        StatusRate= PlayerPrefs.GetInt("StatusRate", 0);
        //PlayerPrefs.SetInt("StatusRate", StatusRate);
    }
    public  GameObject PanelGameOver;
    public  GameObject PanelYouWin;
    public  GameObject ButtonVideoReward;
    public  GameObject CompliteButtonVideoReward;

    public void RestartCurrentLvL()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentSceneIndex);

    }
    public void UseButtonReward(bool status)
    {
        ButtonVideoReward.SetActive(status);
        CompliteButtonVideoReward.SetActive(!status);
    }
    public void ShowRatePanel()
    {
        if (StatusRate < 0) { return; }

        else
        {
            PanelRateGame.SetActive(true);
        }
    }
}
