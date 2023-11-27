using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveListMov : MonoBehaviour
{
    private void OnEnable()
    {
        var anim = GameObject.Find("Anim");
        var canvas = anim.GetComponentInChildren<Canvas>();
        gameObject.transform.parent = canvas.transform;
    }
}
