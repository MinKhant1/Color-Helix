using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController instance;

    public Color[] colors;

    [HideInInspector]
    public Color hitColor, failColor;
    public GameObject[] walls2;


    public GameObject finishLine;
    public bool colorBump;


    int wallSpawnNumber=10;
    float z=7;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        GenerateColor();
        SpawnWall();
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

   public void GenerateLevel()
    {
        z = 7;
        wallSpawnNumber = 12;
        DeleteWalls();
        colorBump = false;
        SpawnWall();

    }

   void DeleteWalls()
    {
        walls2 = GameObject.FindGameObjectsWithTag("Fail");
        if(walls2.Length>1)
        {
            for (int i = 0; i < walls2.Length; i++)
            {
                Destroy(walls2[i].transform.parent.gameObject);

            }
            Destroy(GameObject.Find("ColorBump"));
        }

    }

    void SpawnWall()
    {
        for (int i = 0; i < wallSpawnNumber; i++)
        {
            GameObject wall;

            if(Random.value<=0.2 &&!colorBump)
            {
                colorBump = true;
                wall = Instantiate(Resources.Load("ColorBump") as GameObject, transform.position, Quaternion.identity);

            }
            else if(Random.value<=0.2)
            {
                wall = Instantiate(Resources.Load("Walls") as GameObject, transform.position, Quaternion.identity);
            }
            else if(i>=9 && !colorBump )
            {
                colorBump = true;
                wall = Instantiate(Resources.Load("ColorBump") as GameObject, transform.position, Quaternion.identity);

            }
            {
                wall = Instantiate(Resources.Load("Wall") as GameObject, transform.position, Quaternion.identity);

            }



            wall.transform.localPosition = new Vector3(0, 0, z);
            wall.transform.SetParent(GameObject.Find("Helix").transform);
            float randomRotation = Random.Range(0, 360);
            wall.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, randomRotation));

            z += 7; 

             if(i<=wallSpawnNumber)
            {


                finishLine.transform.position = new Vector3(0, 0.03f, z);
            }


        }
    }
}
