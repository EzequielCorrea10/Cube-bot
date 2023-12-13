using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    public static bool Win;
    GameObject sceneManager;
    GameObject WinVariant;
    GameObject Key;
    private void OnEnable()
    {
        sceneManager = GameObject.Find("SceneManager");
        WinVariant = GameObject.Find("Win Variant");
        Key = GameObject.Find("Key");
        Win = false;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player") && (WinVariant == null && Key == null) )
        {
            SaveInputs.InputsFunc.Clear();
            SaveInputs.Inputs.Clear();
            Win = true;
            sceneManager.GetComponent<sceneLoader>().CheckWin(Win);
        }
        else if(collision.gameObject.CompareTag("Player") )
        {
            SaveInputs.InputsFunc.Clear();
            SaveInputs.Inputs.Clear();
            Win = true;
        }
        
    }
   
}
