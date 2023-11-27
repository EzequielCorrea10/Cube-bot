using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CleanIns : MonoBehaviour
{

    public void CleanInputsListMovs()
    {
        var movs = GameObject.Find("ListOfMovs").GetComponentsInChildren<Image>();
        foreach (var mov in movs)
        {
            mov.sprite = null;
            mov.color = new Color(0, 0, 0, 0);
            mov.tag = "Texts";
        }
        var Number = GameObject.Find("Number").GetComponent<Text>();
        Number.text = "10";
        SaveInputs.Inputs.Clear();
    }

    public void CleanInputsFunc()
    {
        var movs = GameObject.Find("Func").GetComponentsInChildren<Image>();
        foreach (var mov in movs)
        {
            mov.sprite = null;
            mov.color = new Color(0, 0, 0, 0);
            mov.tag = "Texts";
        }

        var Number1 = GameObject.Find("Number1").GetComponent<Text>();
        Number1.text = "4";
        SaveInputs.InputsFunc.Clear();
    }
}
