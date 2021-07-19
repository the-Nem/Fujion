using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibrator :MonoBehaviour
{
    public static bool statusForVibrator = true;
    public static void Vibrate()
    {
        if (!statusForVibrator) { return; }
        Handheld.Vibrate();  //gives error in version for pc
    }
    public static void ChangeStatusVibrator(bool onOff) { statusForVibrator = onOff; }
}
