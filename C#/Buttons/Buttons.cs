using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    public void Quit() { Application.Quit(); }
    public void LinkToInstagram()
    {
        Application.OpenURL("https://www.instagram.com/the_nem.s/");
    }

    public void LinkToPatreon()
    {
        Application.OpenURL("https://www.patreon.com/the_nem_s");
    }
    public void RateUsButton()
    {
        //Application.OpenURL("market://details?id=PackageName");
        Application.OpenURL("market://details?id=com.CompanyName.ProductName");
        UIElements.instance.StatusRate++;
        PlayerPrefs.SetInt("StatusRate", UIElements.instance.StatusRate);

    }
}
