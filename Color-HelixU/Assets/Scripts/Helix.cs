using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helix : MonoBehaviour
{

    bool moveable = true;
    public float angle;
    public float lastDeltaAngle, lastTouchX;

    void Update()
    {
        if (moveable && Touch.IsPressing())
        {

            float mouseX = GetMouseX();
            lastDeltaAngle = lastTouchX - mouseX;
            angle += lastDeltaAngle * 360 * 1.7f;
            lastTouchX = mouseX;

        }
        else if (lastDeltaAngle!=0)
        {
            lastDeltaAngle -= lastDeltaAngle * 5 * Time.deltaTime;
            angle += lastDeltaAngle*360*1.7f;
        }


        transform.eulerAngles = new Vector3(0, 0, angle);

        Debug.Log(angle);

    }
    public float GetMouseX()
    {
        return Input.mousePosition.x /(float) Screen.width;
    }
}
