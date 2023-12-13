using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject LevelSelectorObj;
    public GameObject MenuObj;
    public Text win;
    public Text fail;
    private void Awake()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            SaveInputs.Inputs.Clear();
            SaveInputs.InputsFunc.Clear();
            GameObject.Find("Anim").SetActive(false);
        }
        else { 
        var textos = GameObject.Find("Transition").GetComponentsInChildren<Text>();
        foreach (var texto in textos)
        {
            if (texto.name == "Win")
            {
                win = texto;
            }
            else
            {
                fail = texto;
            }
        }
        }
    }
    public void Play()
    {
        StartCoroutine(animaion());
    }

    public void Tutorial()
    {
        StartCoroutine(TutorialAnim());
    }

    IEnumerator animaion()
    {
        if(fail != null && win != null) { 
        fail.text = "";
        win.text = "";
        }
        var anima = GameObject.Find("Transition");
        var anim = anima.GetComponent<Animator>();
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(0.9f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }

    IEnumerator TutorialAnim()
    {
        var anima = GameObject.Find("Transition");
        var anim = anima.GetComponent<Animator>();
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Tutorial");
    }


    public void LevelSelector()
    {
        LevelSelectorObj.SetActive(true);
        MenuObj.SetActive(false);
    }
    public void Back()
    {
        MenuObj.SetActive(true);
        LevelSelectorObj.SetActive(false);
    }
    public void Home()
    {
        StartCoroutine(animaionMenu());
    }

    IEnumerator animaionMenu()
    {
        if (fail != null && win != null)
        {
            fail.text = "";
            win.text = "";
        }
        var anima = GameObject.Find("Transition");
        var anim = anima.GetComponent<Animator>();
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
