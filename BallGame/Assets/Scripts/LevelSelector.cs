using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void Level()
    {
        StartCoroutine(animaion());
    }

    IEnumerator animaion()
    {
        var anima = GameObject.Find("Transition");
        var anim = anima.GetComponent<Animator>();
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(0.8f);
        string level = gameObject.name;
        SceneManager.LoadScene(level);
    }
}
