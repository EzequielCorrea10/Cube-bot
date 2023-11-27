using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveInputs : MonoBehaviour
{
    public static List<int> Inputs = new List<int>();
    public static List<int?> InputsFunc = new List<int?>();
    public static int backMov;
   public static bool deleteMovs = false;
    public Image num1;
    public Image num2;
    public Image num3;
    public Image num4;
    GameObject list;
    GameObject func;

    private void Awake()
    {
        list = GameObject.Find("ListOfmovements");
        func = GameObject.Find("Function");

    }

    private void Update()
    {
        movements();
        
    }

    void movements()
    {
        if(list.GetComponent<Image>().color == new Color(1, (float)0.93, (float)0, 1) && Inputs.Count<10)
        {
            if (Buttons.movPlayer == 1)
            {
                Inputs.Add(Buttons.movPlayer);
                Buttons.movPlayer = 0;
            }
            else if (Buttons.movPlayer == 2)
            {
                Inputs.Add(Buttons.movPlayer);
                Buttons.movPlayer = 0;
            }
            else if (Buttons.movPlayer == 3)
            {
                Inputs.Add(Buttons.movPlayer);
                Buttons.movPlayer = 0;
            }
            else if (Buttons.movPlayer == 4)
            {
                Inputs.Add(Buttons.movPlayer);
                Buttons.movPlayer = 0;
            }
            else if (Buttons.movPlayer == 5)
            {
                Inputs.Add(Buttons.movPlayer);
                Buttons.movPlayer = 0;

            }
        }
        else if (func.GetComponent<Image>().color == new Color(1, (float)0.93, 0, 1))
        {
            if (Buttons.movPlayer == 1)
            {
                InputsFunc.Add(Buttons.movPlayer);
                Buttons.movPlayer = 0;
            }
            else if (Buttons.movPlayer == 2)
            {
                InputsFunc.Add(Buttons.movPlayer);
                Buttons.movPlayer = 0;
            }
            else if (Buttons.movPlayer == 3)
            {
                InputsFunc.Add(Buttons.movPlayer);
                Buttons.movPlayer = 0;
            }
            else if (Buttons.movPlayer == 4)
            {
                InputsFunc.Add(Buttons.movPlayer);
                Buttons.movPlayer = 0;
            }
        }

    }

   public void resetMov()
    {
        deleteMovs = true;
         
    }

    public void deleteList()
    {
        for(int i = Inputs.Count; i > 0; i--)
        {
            Debug.Log("si");
            Inputs.RemoveAt(i);
        }
    }

}
