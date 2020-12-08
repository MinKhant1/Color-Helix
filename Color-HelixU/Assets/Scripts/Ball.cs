using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static float z;
    private float height = 0.58f, speed = 6;


     static Color currentColor;
    MeshRenderer meshrenderer;

    bool move;


    // Start is called before the first frame update
    void Start()
    {

        meshrenderer = GetComponent<MeshRenderer>();
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Touch.IsPressing())
        {
            move = true;
        }
        if (move)
            Ball.z += speed * 0.025f;
        transform.position = new Vector3(0, height, Ball.z);

        UpdateColor();
        
    }



    void UpdateColor()
    {
        meshrenderer.sharedMaterial.color = currentColor;
    }

    public static Color SetColor(Color color)
    {
        return currentColor = color;
    }
    public static Color GetColor()
    {
        return currentColor;
    }


    public static float GetZ()
    {
        return Ball.z;
    }
}
