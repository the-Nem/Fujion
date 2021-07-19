using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            The_Score.instance.CoinCalculation(1);
            AudioManagment.instance.IncomeMoney();
            Vibrator.Vibrate();
            SavePrefs.instance.SaveData();
            
        }
    }
}
