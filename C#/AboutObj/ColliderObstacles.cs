using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderObstacles : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Bonus.instance.boolShiledStatus == true) { return; }
        if (collision.gameObject.tag == "Player")
        {
            LifeManagment.instance.LiveManipulations(-1);
            AudioManagment.instance.HitSomething();
            Vibrator.Vibrate();
        }
    }

}
