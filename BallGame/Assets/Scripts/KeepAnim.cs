using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeepAnim : MonoBehaviour
{
    public static KeepAnim instance;
    public static bool iniciarCin=false;
    public static Text win;
    public static Text fail;
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

    private void Start()
    {
        if (!sceneLoader.failAnim && !sceneLoader.winAnim)
        {
            win.text = "";
            fail.text = "";
        }
        else if (sceneLoader.winAnim)
        {
            win.text = "YOU WIN";
            fail.text = "";
            sceneLoader.winAnim = false;
        }
        else if (sceneLoader.failAnim)
        {
            fail.text = "YOU FAIL";
            win.text = "";
            sceneLoader.failAnim = false;
        }
        
    }

    private void FixedUpdate()
    {
        var Image = GameObject.Find("Transition");
        var anim = Image.GetComponent<Animator>();
        var anim2 = Image.GetComponent<Animator>();

        if (iniciarCin)
        {
            Debug.Log("si");
            anim.Play("StartLevel");
            iniciarCin = false;
        }

    }
}
