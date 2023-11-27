using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraManager : MonoBehaviour
{
    Scene scene;
    int y = 0; 
    /*
    private void FixedUpdate()
    {
        if(y == 0) { 
       scene = SceneManager.GetActiveScene();
        switch (scene.name)
        {
            case "Level4":
                Camera.main.transform.position = new Vector3(2, 2, 0);
                    y++;
                break;
            default:
                break;
        }
        }
    }*/
}
