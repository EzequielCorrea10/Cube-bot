using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        followPlayer();         
    }
    void followPlayer()
    {
        for (int i = 0; i < SaveInputs.Inputs.Count; i++)
        {
            if (SaveInputs.Inputs[i] == 1 && Play.play)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1);
                Buttons.movPlayer = 0;
                Play.play = false;
            }
            if (SaveInputs.Inputs[i] == 2 && Play.play)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
                Buttons.movPlayer = 0;
                Play.play = false;

            }
            if (SaveInputs.Inputs[i] == 3 && Play.play)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
                Buttons.movPlayer = 0;
                Play.play = false;
            }
            if (SaveInputs.Inputs[i] == 4 && Play.play)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1);
                Buttons.movPlayer = 0;
                Play.play = false;

            }
        }
    }
}

