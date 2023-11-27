using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeepAnim : MonoBehaviour
{
    public static KeepAnim instance;
    public static bool iniciarCin=false;
    
    private void Update()
    {

        var Image = GameObject.Find("Transition");
        var anim = Image.GetComponent<Animator>();

        if (iniciarCin)
        {
            Debug.Log("si");
            anim.Play("StartLevel");
            iniciarCin = false;
        }
    }
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
}
