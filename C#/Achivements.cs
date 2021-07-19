//using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achivements : MonoBehaviour
{

    public static Achivements instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
    }

    [SerializeField] private GameObject[] doneImage;   // Картинки с галочками
    public GameObject StarAch1;
    public GameObject StarAch2;
    public GameObject StarAch3;



    private int numberOfFinishedLvlS=0;
    //private int countFinishedLVLs;

    private int requirement_FinithFirstLVL = 1;
    private int requirement_20_FinishedLvls=20;
    private int requirement_100_FinishedLvls = 100;

    private void Start()
    {

    }

    private void Update()
    {
        CheckAchInPanel();
    }

    public void CheckAchInPanel()
    {
        if (numberOfFinishedLvlS == requirement_FinithFirstLVL) { StarAch1.gameObject.SetActive(true); }
        else { StarAch1.gameObject.SetActive(false); }
        if (numberOfFinishedLvlS > requirement_20_FinishedLvls) { StarAch2.gameObject.SetActive(true); }
        else { StarAch2.gameObject.SetActive(false); }
        if (numberOfFinishedLvlS > requirement_100_FinishedLvls) { StarAch3.gameObject.SetActive(true); }
        else { StarAch3.gameObject.SetActive(false); }
    }


    public void AddFinishedLvl(int i) { numberOfFinishedLvlS += i; }

    //public void OnTakeBonus(string bonusName)
    //{
    //    if (bonusName=="Shield" && doneImage[3].activeSelf == false)
    //        doneImage[3].SetActive(true);
    //    if (bonusName == "Time" && doneImage[4].activeSelf == false)
    //        doneImage[4].SetActive(true);
    //    if (bonusName == "Heart" && doneImage[5].activeSelf == false)
    //        doneImage[5].SetActive(true);
    //}
}
