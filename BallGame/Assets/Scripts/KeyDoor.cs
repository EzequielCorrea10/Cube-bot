using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    bool doorOpen;
    Material material;
    private void OnEnable()
    {
        doorOpen = false;
        var player = GameObject.Find("Player");
        material = player.GetComponent<Renderer>().sharedMaterial;

    }
    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.tag == "Player")
            {
            doorOpen = true;


            }
        
    }

    private void Update()
    {
        openDoor();
    }
    void openDoor()
    {
        if (doorOpen) {
            var doors = GameObject.FindGameObjectsWithTag("Door");
            foreach(var door in doors) { 
            door.SetActive(false);

            }

            var lost = GameObject.FindGameObjectsWithTag("Lost");
            if (lost != null)
            {
                
                foreach (var lostTrigger in lost)
                {
                    Debug.Log("si");
                  var col=  lostTrigger.GetComponent<Collider>();
                    col.enabled=true;
                }
            }

        }
    }
}
