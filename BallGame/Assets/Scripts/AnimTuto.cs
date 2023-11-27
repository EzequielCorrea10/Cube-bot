using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class AnimTuto : MonoBehaviour, IPointerClickHandler
{
    public static bool pressed = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        pressed = true;
    }

}
