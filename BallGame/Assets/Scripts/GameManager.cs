using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject sceneManager;
    GameObject player;
    bool animPlay;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        sceneManager = GameObject.Find("SceneManager");
        player = GameObject.Find("Player");
        animPlay = true;

    }
    void Update()
    {
        if( player.transform.position.y < -15 && player.transform.position.y > -30 && animPlay)
        {
            player.transform.position = new Vector3(100, 100, 100);
            endTurn(true);

        }
    }

    public void endTurn(bool turnOver)
    {
        if(turnOver && !WinTrigger.Win && animPlay)
        {
            sceneManager.GetComponent<sceneLoader>().resetScene();
            animPlay = false;
        }
    }
}
