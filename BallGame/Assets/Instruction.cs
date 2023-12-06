using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    public GameObject Block;
    public GameObject[] Tutorial;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if(Block.activeInHierarchy && Input.GetMouseButtonDown(0))
        {
            Block.SetActive(false);
            for (int i = 0; i < Tutorial.Length; i++)
            {
                Tutorial[i].SetActive(false);
            }
        }
    }

    public void instruction()
    {
        Block.SetActive(true);
        for (int i = 0; i < Tutorial.Length; i++)
        {
            Tutorial[i].SetActive(true);
        }
    }
}
