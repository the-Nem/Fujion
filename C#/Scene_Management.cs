using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Management : MonoBehaviour
{
    public int finishedLvls = 0;

    public static Scene_Management instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
    }



    //public void LoadScene1() { SceneManager.LoadScene(1); }
    public void StartLVL() 
    {
        if (finishedLvls == 0) { SceneManager.LoadScene(1); }
        else { SceneManager.LoadScene(finishedLvls); }



    }
    public void NextLvlData()
    {
        int acticeScene = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = ++acticeScene;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings) { nextSceneIndex = 1; }
        SceneManager.LoadScene(nextSceneIndex);
    }
}
