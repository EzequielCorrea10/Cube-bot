using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColorWIn : MonoBehaviour
{
    public static bool keyWin;
    GameObject sceneManager;
    GameObject WinVariant;
    GameObject Lock;

    private void Awake()
    {
        Lock = GameObject.Find("Lock");
    }

    private void OnEnable()
    {
        sceneManager = GameObject.Find("SceneManager");
        WinVariant = GameObject.Find("Win Variant");
        keyWin = false;
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (WinTrigger.Win)
        {
            Material color = gameObject.GetComponent<Renderer>().material;
            var player = GameObject.FindGameObjectWithTag("Player");
            Renderer keyMaterial = player.GetComponent<Renderer>();

            if (KeyManager.keyTocuhed && Lock!=null)
            {
                keyWin = true;
                sceneManager.GetComponent<sceneLoader>().CheckWin(keyWin);
            }
            else
            {
                keyWin = false;
                sceneManager.GetComponent<sceneLoader>().resetScene();
            }

        }
    }
}
