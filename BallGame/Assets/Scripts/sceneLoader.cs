using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public static sceneLoader instance;
   public static bool gano = false;
   public static bool winAnim = false;
   public static bool failAnim = false;
    public GameObject Anim;
    public GameObject Music;
    GameObject ui;
    GameObject uiNoFunc;
    public  Text win;
    public  Text fail;

    private void Awake()
    {
        if (instance == null)
        {
           instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
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


    private void Update()
    {
        if (SceneManager.GetActiveScene().name != "Level0" )
        {
            Anim.SetActive(true);
            Music.SetActive(true);
        }
        else
        {
            Music.SetActive(false);
        }
    }
    public void CheckWin(bool Win)
    {
        if (Win)
            {
            SaveInputs.Inputs.Clear();
            StartCoroutine(animaion());
            gano = true;
            }
    }

    public void resetScene()
    {
        SaveInputs.Inputs.Clear();
        SaveInputs.InputsFunc.Clear();

        StartCoroutine(reset());
    }

    IEnumerator animaion()
    {
        ui = GameObject.Find("UI2NoFunc");
        uiNoFunc = GameObject.Find("FUNC");
        if (ui != null)
        {
            ui.SetActive(false);
        }
        else
        {
            uiNoFunc.SetActive(false);
        }
        win.text = "Level complete";
        fail.text = "";
        var anima = GameObject.Find("Transition");
        var anim = anima.GetComponent<Animator>();
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(0.8f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if(currentScene != 15)
        {
            SceneManager.LoadScene(currentScene + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        Player.lastnum.Clear();
        KeepAnim.iniciarCin = true;
        gano = false;
        winAnim = true;
    }
    public IEnumerator reset()
    {
        ui = GameObject.Find("UI2NoFunc");
        uiNoFunc = GameObject.Find("FUNC");
        if (ui != null)
        {
            ui.SetActive(false);
        }
        else
        {
            uiNoFunc.SetActive(false);
        }
        win.text = "";
        fail.text = "Try again";

        var anima = GameObject.Find("Transition");
        var anim = anima.GetComponent<Animator>();
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(0.8f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
        Player.lastnum.Clear();
        KeepAnim.iniciarCin = true;
        gano = false;
        failAnim = true;
    }
}
