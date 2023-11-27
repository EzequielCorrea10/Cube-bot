using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public static int movPlayer;

    public void Mov1()
    {
        movPlayer = 1;
        var objs = GameObject.FindGameObjectsWithTag("Buttons");
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].name == "1")
            {
                var imag = objs[i].GetComponentInChildren<Image>();
                imag.tag = "Selected";
                AudioManager.Play = true;
                AudioManager.playerMov = false;
                AudioManager.pressButton = true;
                break;
            }
        }

    }
    public void Mov2()
    {
        movPlayer = 2;
        var objs = GameObject.FindGameObjectsWithTag("Buttons");
        for (int i = 0; i < objs.Length; i++)
        {
            if(objs[i].name == "2")
            {
                var imag = objs[i].GetComponentInChildren<Image>();
                imag.tag = "Selected";
                AudioManager.Play = true;
                AudioManager.playerMov = false;
                AudioManager.pressButton = true;
                break;
            }
        }

    }
    public void Mov3()
    {
        movPlayer = 3;
        var objs = GameObject.FindGameObjectsWithTag("Buttons");
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].name == "3")
            {
                var imag = objs[i].GetComponentInChildren<Image>();
                imag.tag = "Selected";
                AudioManager.Play = true;
                AudioManager.playerMov = false;
                AudioManager.pressButton = true;
                break;
            }
        }
    }
    public void Mov4()
    {
        movPlayer = 4;
        var objs = GameObject.FindGameObjectsWithTag("Buttons");
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].name == "4")
            {
                var imag = objs[i].GetComponentInChildren<Image>();
                imag.tag = "Selected";
                AudioManager.Play = true;
                AudioManager.playerMov = false;
                AudioManager.pressButton = true;
                break;
            }
        }
    }

    public void F()
    {
        movPlayer = 5; //Function
        var objs = GameObject.FindGameObjectsWithTag("Buttons");
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].name == "Fx")
            {
                var imag = objs[i].GetComponentInChildren<Image>();
                imag.tag = "Selected";
                AudioManager.Play = true;
                AudioManager.playerMov = false;
                AudioManager.pressButton = true;
                break;
            }
        }
    }
}
