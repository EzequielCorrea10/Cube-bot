using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public static sceneLoader instance;
   public static bool gano = false;
    public GameObject Anim;
    public GameObject Music;
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
        var anima = GameObject.Find("Transition");
        var anim = anima.GetComponent<Animator>();
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
        Player.lastnum.Clear();
        KeepAnim.iniciarCin = true;
        gano = false;

    }
    public static IEnumerator reset()
    {
        var anima = GameObject.Find("Transition");
        var anim = anima.GetComponent<Animator>();
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
        Player.lastnum.Clear();
        KeepAnim.iniciarCin = true;
        gano = false;
    }
}
