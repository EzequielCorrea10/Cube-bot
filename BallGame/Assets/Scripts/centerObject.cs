using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class centerObject : MonoBehaviour
{
    Scene scene;

    // Start is called before the first frame update
    private void Awake()
    {
        gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 1.5f, Camera.main.nearClipPlane + 20));
        scene = SceneManager.GetActiveScene();
        switch (scene.name)
        {
            case "Level2":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x -0.5f , gameObject.transform.position.y - 1.5f, gameObject.transform.position.z);
                break;
            case "Level3":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y -1, gameObject.transform.position.z);
                break;
            case "Level4":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1.5f, gameObject.transform.position.y + 2, 0);
                break;
            case "Level5":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1.5f, gameObject.transform.position.y -2 , 0);
                break;
            case "Level6":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1f, gameObject.transform.position.y + 1.5f, 0);
                break;
            case "Level7":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x , gameObject.transform.position.y + 0.5f, 0);
                break;
            case "Level8":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x +3.3f, gameObject.transform.position.y +3, 0);
                break;
            case "Level9":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 5f, gameObject.transform.position.y + 1f, 0);
                break;
            case "Level10":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x +2.3f, gameObject.transform.position.y+0.5f, 0);
                break;
            case "Level11":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1.2f, gameObject.transform.position.y + 1.5f, 0);
                break;
            case "Level12":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 3f, gameObject.transform.position.y + 1f, 0);
                break;
            case "Level13":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.5f, gameObject.transform.position.y + 1.5f, 0);
                break;
            case "Level14":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x +1.2f, gameObject.transform.position.y + 1.5f, 0);
                break;
            case "Level15":
                gameObject.transform.position = new Vector3(gameObject.transform.position.x +1.3f, gameObject.transform.position.y , 0);
                break;
            default:
                break;
        }
    }
}

