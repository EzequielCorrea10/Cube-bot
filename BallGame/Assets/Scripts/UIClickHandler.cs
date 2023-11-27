using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIClickHandler : MonoBehaviour, IPointerClickHandler
{
    Image image;
    Color baseColor;
    GameObject function;
    GameObject list;
    GameObject Fx;

    private void Awake()
    {
        function = GameObject.Find("Function");
        list = GameObject.Find("ListOfmovements");
        Fx = GameObject.Find("Fx");
        baseColor = new Color((float)0.8207547, (float)0.8207547, (float)0.8207547, (float)0.3960784);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Obtener la referencia al objeto que se hizo clic
        GameObject clickedObject = eventData.pointerPress;
        // Verificar el nombre de la imagen
        if (clickedObject.name == "ListOfmovements") //Si se apreta la lista, se cambia el color 
        {
            function.GetComponent<Image>().color = baseColor;
            list.GetComponent<Image>().color = new Color((float)1, (float)0.93, (float)0, (float)1);
            Fx.GetComponent<Image>().color = new Color((float)1, (float)0.93, (float)0, (float)1);
            AudioManager.Play = true;
            AudioManager.playerMov = false;
            AudioManager.pressButton = false;
        }
        else if (clickedObject.name == "Function") //Si se apreta el Function, se cambia el color y se bloquea el boton F
        {
            list.GetComponent<Image>().color = baseColor;
            function.GetComponent<Image>().color = new Color((float)1, (float)0.93, (float)0, (float)1);
            Fx.GetComponent<Image>().color = baseColor;
            AudioManager.Play = true;
            AudioManager.playerMov = false;
            AudioManager.pressButton = false;
        }
    }
}
    


