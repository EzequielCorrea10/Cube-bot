using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementLeft : MonoBehaviour
{
    public GameObject child;
    Text Number;
    Text Number1;
    Image[] images;
    private void Awake()
    {
        images = child.GetComponentsInChildren<Image>();

        if (this.gameObject.name == "Function")
        {
            Number1 = GameObject.Find("Number1").GetComponent<Text>();
            Number1.text = images.Length.ToString();

        }
        else
        {
            Number = GameObject.Find("Number").GetComponent<Text>();
            Number.text = images.Length.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name == "Function") { 
            for (int i = 0; i < images.Length; i++)
        {
                if (images[i].tag == "Untagged")
                {
                    Number1.text = (images.Length - (i+1)).ToString();
                }
            }
        }
        else
        {
            for (int i = 0; i < images.Length; i++)
            {
                if (images[i].tag == "Untagged")
                {
                    Number.text = (images.Length - (i+1)).ToString();
                }
            }

        }
    }
}

