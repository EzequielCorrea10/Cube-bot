using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public static bool play;

    public void PlayBehaviour()
    {
        if (SaveInputs.Inputs.Count > 0) {
        play = true;
        }
    }
}
