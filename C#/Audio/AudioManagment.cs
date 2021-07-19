using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagment : MonoBehaviour
{
    public static AudioManagment instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }

    }


    public AudioSource ContantLounge; //    //
    public AudioSource SpendCoints;  // //
    public AudioSource AddCoinInGame;// //
    public AudioSource HitObstacle; //  //
    public AudioSource FinishLvl;   //  //


    public AudioSource UseBonus;    //  //

    public void SpendSomeMonery()
    {
       // if (ContantLounge.isPlaying) { ContantLounge.Pause(); ContantLounge.Play(); Invoke("ContantLounge.Play()", 2f); ContantLounge.Play(); }
        ContantLounge.Play(); 
    }
    public  void HitSomething()
    {
        //if (ContantLounge.isPlaying) { ContantLounge.Pause(); HitObstacle.Play(); Invoke("ContantLounge.Play()", 2f); //ContantLounge.Play(); 
        //}
        //else { ContantLounge.Play(); }

        HitObstacle.Play();


    }
    public void WIN()
    {
        //if (ContantLounge.isPlaying) { ContantLounge.Pause(); FinishLvl.Play(); ContantLounge.Play(); }
        FinishLvl.Play();
    }
    public void UseSomeBonus()
    {
        //if (ContantLounge.isPlaying) { ContantLounge.Pause(); FinishLvl.Play(); ContantLounge.Play(); }
        UseBonus.Play();
    }
    public void IncomeMoney()
    {
        //if (ContantLounge.isPlaying) { ContantLounge.Pause(); FinishLvl.Play(); ContantLounge.Play(); }
        AddCoinInGame.Play();
    }
    public void PauseMusic()
    {
        ContantLounge.Pause();
    }
    public void UnPauseMusic()
    {
        ContantLounge.UnPause();

    }
}
