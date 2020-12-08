using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Touch : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{


    public static bool pressing;

    public static bool IsPressing()
    {

        if (pressing)
        {
            
        }
        else
        {

        }

        return pressing;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {

        pressing = false;
    }
    public void pointerenter()
    {
        Debug.Log("Enter");
    }
    public void pointerexit()
    {

        Debug.Log("Exit");
    }



}
