using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoBright : MonoBehaviour
{
    float metalic = 1;
    bool metall = true;
    bool toco = false;


    private void Update()
    {
        bright();
    }
    void bright()
    {
        Material metal = gameObject.GetComponent<Renderer>().sharedMaterial;
        if (!toco)
        {
            if (metalic >= 0 && metall)
            {
                metalic -= 0.01f;
                metal.SetFloat("_Metallic", metalic);
                if (metalic <= 0.1f)
                {
                    metall = false;
                }
            }
            else if (metalic <= 1 && !metall)
            {
                metalic += 0.01f;
                metal.SetFloat("_Metallic", metalic);
                if (metalic >= 0.9f)
                {
                    metall = true;
                }
            }



        }
        else
        {
            metal.SetFloat("_Metallic", 0);
        }
    }
}
