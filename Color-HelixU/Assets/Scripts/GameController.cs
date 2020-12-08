using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController instance;

    public Color[] colors;

    [HideInInspector]
    public Color hitColor, failColor;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        GenerateColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateColor()
    {

        hitColor = colors[Random.Range(0, colors.Length)];
        failColor = colors[Random.Range(0, colors.Length)];
        while(hitColor==failColor)
        {
            failColor = colors[Random.Range(0, colors.Length)];
        }

        Ball.SetColor(hitColor);

    }
}
