using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class writeInputs : MonoBehaviour
{
    public Image[] image;

    private void Awake()
    {
        var list = this.gameObject;
        image = list.GetComponentsInChildren<Image>();
    }

    public void writeNumbers()
    {
        if(this.GetComponentInParent<Image>().color == new Color((float)1, (float)0.93, (float)0, (float)1)) { 
        for (int i=0; i <= image.Length; i++)
        {
            if (image[i].tag != "Untagged")
            {
                    var imag = GameObject.FindGameObjectWithTag("Selected");
                    var img = imag.GetComponent<Image>();
                    image[i].sprite = img.sprite;
                    image[i].color = new Color(1, 1, 1, 1);
                    imag.tag = "Buttons";
                    image[i].tag = "Untagged";
                    break;
                }
        }
        }
    }

    private void FixedUpdate()
    {
        try
        {
            var imag = GameObject.FindGameObjectWithTag("Selected");
            imag.tag = "Buttons";
        }
        catch (NullReferenceException err)
        {
        }
    }
}
