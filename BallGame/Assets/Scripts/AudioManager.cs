using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip PlayerMov;
    public AudioClip Select;
    public AudioClip Press;
    private AudioSource audioSource;
    public static bool Play = false;
    public static bool playerMov = false;
    public static bool pressButton = false;

    void Start()
    {
        audioSource = GetComponent <AudioSource>();
        Play = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Play && playerMov && !pressButton)
        {
            audioSource.clip = PlayerMov;
            audioSource.Play();
            Play = false;
        }
        else if (Play && !playerMov && !pressButton)
        {
            audioSource.clip = Select;
            audioSource.Play();
            Play = false;
        }
        else if (Play && !playerMov && pressButton)
        {
            audioSource.clip = Press;
            audioSource.Play();
            Play = false;
        }
    }
}
