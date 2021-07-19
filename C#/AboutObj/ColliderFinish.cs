using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderFinish : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.gameStatus = false;
            UIElements.instance.PanelYouWin.SetActive(true);
            Scene_Management.instance.finishedLvls++;
            //Achivements.instance.AddFinishedLvl(1);
            UIElements.instance.ShowRatePanel();
        }
    }

}
