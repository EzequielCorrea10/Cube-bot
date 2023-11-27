using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class BackColorandText : MonoBehaviour
{
    int numReset;
    public Image num1;
    public Image num2;
    public Image num3;
    public Image num4;

    public static bool undo = false;
    public void resetState()
    {
        
        if (Player.lastnum!=null)
        {
            Debug.Log(Player.lastnum.Count);
            numReset = Player.lastnum.Pop();
            if (numReset==1)
            {
                num1.color = new Color(num1.color.r + 0.25f, num1.color.g + 0.25f, num1.color.b + 0.25f);
                undo = false;
            }
            else if (numReset == 2)
            {
                num2.color = new Color(num2.color.r + 0.25f, num2.color.g + 0.25f, num2.color.b + 0.25f);
                undo = false;

            }
            else if (numReset == 3)
            {
                num3.color = new Color(num3.color.r + 0.25f, num3.color.g + 0.25f, num3.color.b + 0.25f);
                undo = false;

            }
            else if (numReset == 4)
            {
                num4.color = new Color(num4.color.r + 0.25f, num4.color.g + 0.25f, num4.color.b + 0.25f);
                undo = false;

            }


        }

    }
}
