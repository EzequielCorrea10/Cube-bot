using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramesManager : MonoBehaviour
{
    public static FramesManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DontDestroyOnLoad(this);
        }
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
    }
}
