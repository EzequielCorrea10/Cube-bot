using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TutoManager : MonoBehaviour
{
    Scene scene;
    GameObject tuto1;
    GameObject tuto2;
    GameObject tuto3;
    GameObject tuto4;
    GameObject tuto5;
    GameObject tuto6;
    GameObject tuto2Block;
    GameObject tuto3Block;
    GameObject tuto1Block;
    GameObject tuto4Block;
    GameObject tuto5Block;
    GameObject tuto6Block;
    GameObject tuto7Block;
    bool level2 = false;
    public GameObject listMovColor;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        tuto1 = GameObject.Find("Tuto1");
        tuto2 = GameObject.Find("Tuto2");
        tuto3 = GameObject.Find("Tuto3");
        tuto2Block = GameObject.Find("Tuto2Block");
        tuto3Block = GameObject.Find("Tuto3Block");
        tuto1Block = GameObject.Find("Tuto1Block");
        tuto1Block = GameObject.Find("Tuto1Block");

        if (scene.name != "Level5") { 
            tuto2.SetActive(false);
        tuto3.SetActive(false);
        tuto2Block.SetActive(false);
        tuto3Block.SetActive(false);
        tuto1.SetActive(false);
        tuto1Block.SetActive(false);
            Invoke("level1Anim", 0.7f);
        }
        else
        {
            AnimTuto.pressed = false;
            level2 = true;
            tuto1Block.SetActive(false);
            tuto1.SetActive(false);
            tuto2.SetActive(false);
            tuto3.SetActive(false);
            tuto2Block.SetActive(false);
            tuto3Block.SetActive(false);
            tuto4 = GameObject.Find("Tuto4");
            tuto4Block = GameObject.Find("Tuto4Block");
            tuto5Block = GameObject.Find("Tuto5Block");
            tuto6Block = GameObject.Find("Tuto6Block");
            tuto7Block = GameObject.Find("Tuto7Block");

            tuto4.SetActive(false);
            tuto4Block.SetActive(false);
            tuto6Block.SetActive(false);
            tuto7Block.SetActive(false);
            tuto5 = GameObject.Find("Tuto5");
            tuto6 = GameObject.Find("Tuto6");
            tuto5.SetActive(false);
            tuto6.SetActive(false);
            tuto5Block.SetActive(false);
            Invoke("level2Anim",0.7f);
        }
    }
    void level1Anim()
    {
        tuto2Block.SetActive(true);
        tuto2.SetActive(true);
    }
    void level2Anim()
    {
        tuto1Block.SetActive(true);
        tuto1.SetActive(true);
    }

    private void Update()
    {
        if (!level2) { 
        if (tuto2.activeInHierarchy && SaveInputs.Inputs.Count == 4)
        {
            tuto2Block.SetActive(false);
            tuto2.SetActive(false);
            tuto3Block.SetActive(true);
            tuto3.SetActive(true);
            AudioManager.Play = true;
            AudioManager.playerMov = false;
        }
        if (tuto3.activeInHierarchy && Play.play)
        {
            tuto3Block.SetActive(false);
            tuto3.SetActive(false);
            AudioManager.Play = true;
            AudioManager.playerMov = false;
         }
        }
        else
        {
            if (AnimTuto.pressed && tuto1.activeInHierarchy)
            {
                tuto2Block.SetActive(true);
                tuto2.SetActive(true);
                tuto1Block.SetActive(false);
                tuto1.SetActive(false);
                AudioManager.Play = true;
                AudioManager.playerMov = false;
            }
            if (AnimTuto.pressed && tuto2.activeInHierarchy && SaveInputs.InputsFunc.Count == 4)
            {
                tuto2Block.SetActive(false);
                tuto2.SetActive(false);
                tuto3Block.SetActive(true);
                tuto3.SetActive(true);
                AudioManager.Play = true;
                AudioManager.playerMov = false;
            }
            if (AnimTuto.pressed && tuto3.activeInHierarchy && listMovColor.GetComponent<Image>().color == new Color((float)1, (float)0.93, (float)0, (float)1))
            {
                tuto3Block.SetActive(false);
                tuto3.SetActive(false);
                tuto4.SetActive(true);
                tuto4Block.SetActive(true);
                AudioManager.Play = true;
                AudioManager.playerMov = false;
            }
            if (AnimTuto.pressed && tuto4.activeInHierarchy && SaveInputs.Inputs.Count == 1)
            {
                tuto4Block.SetActive(false);
                tuto4.SetActive(false);
                tuto6.SetActive(true);
                tuto5Block.SetActive(true);
                AudioManager.Play = true;
                AudioManager.playerMov = false;
            }
            if (AnimTuto.pressed && tuto6.activeInHierarchy && SaveInputs.Inputs.Count == 4)
            {
                tuto4.SetActive(true);
                tuto6.SetActive(false);
                tuto6Block.SetActive(true);
                tuto5Block.SetActive(false);
                AudioManager.Play = true;
                AudioManager.playerMov = false;
            }
            if (AnimTuto.pressed &&  tuto4.activeInHierarchy  && SaveInputs.Inputs.Count == 5)
            {
                tuto6Block.SetActive(false);
                tuto7Block.SetActive(true);
                tuto5.SetActive(true);
                tuto4.SetActive(false);
                AudioManager.Play = true;
                AudioManager.playerMov = false;
            }
            if (AnimTuto.pressed && tuto5.activeInHierarchy && Play.play)
            {
                tuto7Block.SetActive(false);
                tuto5.SetActive(false);
                tuto5Block.SetActive(false);
                AudioManager.Play = true;
                AudioManager.playerMov = false;
            }
        }
    }

}
