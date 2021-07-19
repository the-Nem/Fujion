using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbbilityS : MonoBehaviour
{
    //private const string coin = "Coin", shield = "Shield", addHeart = "Heart", slowTime = "Time";
    //private bool activeShield = false;
    //private bool isDead = false;
    //private int quantityCoints
    //{
    //    set
    //    {
    //        if (value > 0)
    //        {
    //            quantityCoints += value; // просто нельзя поставить значение меньше нуля
    //        }
    //    }
    //    get { return quantityCoints; }
    //}

    //private void AddScore(int x)
    //{
    //    quantityCoints += x;
    //}
    //private void ChangeState(bool state, ref bool value)
    //{
    //    value = state;
    //    if (activeShield == true)
    //    {
    //        StartCoroutine(waiter(6, 0)); // корутина с ожиданием , тоже время поставь
    //    }
    //}
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    switch (collision.tag)
    //    {
    //        case coin:
    //            AddScore(1);
    //            break;
    //        case addHeart:
    //            ChangeState(false, ref isDead);   // изменение состояние на нужное
    //            break;
    //        case shield:
    //            ChangeState(true, ref activeShield); // изменение состояние на нужное
    //            break;
    //        case slowTime:
    //            Time.timeScale = 2f; // Поставь нужное замедление 
    //            waiter(10, 1);   // время поставь
    //            break;
    //    }
    //}
    //private IEnumerator waiter(int timeS, int value)
    //{
    //    yield return new WaitForSeconds(timeS); // время через которое будет действие
    //    if (value == 0) activeShield = false;
    //    if (value == 1) Time.timeScale = 1f;
    //}
}
