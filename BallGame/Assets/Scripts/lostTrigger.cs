using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lostTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){

           StartCoroutine( sceneLoader.reset());

        }
    }


}
