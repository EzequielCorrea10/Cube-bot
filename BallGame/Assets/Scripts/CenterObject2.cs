using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterObject2 : MonoBehaviour
{
    private void Awake()
    {

        gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 1.2f, Camera.main.nearClipPlane + 20));

    }
}
