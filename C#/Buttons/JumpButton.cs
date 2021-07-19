//using System.Collections;
//using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        JumpForFire.instance.JumpBool();
        JumpForWater.instance.JumpBool();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        JumpForFire.instance.JumpBool();
        JumpForWater.instance.JumpBool();

    }

}
