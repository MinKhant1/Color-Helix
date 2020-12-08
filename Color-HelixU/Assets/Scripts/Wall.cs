using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{


    GameObject wallFragment;

    GameObject wall1, wall2;
    float rotationZ;
    float rotationZMax = 180;
    // Start is called before the first frame update
    void Awake()
    {
        wallFragment = Resources.Load("WallFragment") as GameObject;

    }
    private void Start()
    {
        SpawnWallFragments();
    }

    private void SpawnWallFragments()
    {

        wall1 = new GameObject();
        wall2 = new GameObject();
        wall1.name = "Wall1";
        wall2.name = "Wall2";

        wall1.transform.SetParent(transform);
        wall2.transform.SetParent(transform);

        for (int i = 0; i < 100; i++)
        {
            GameObject WallF = Instantiate(wallFragment, transform.position, Quaternion.Euler(0, 0, rotationZ));
            rotationZ += 3.6f;

            if (rotationZ <= rotationZMax)
            {
                WallF.transform.SetParent(wall1.transform);
                WallF.transform.tag = "Hit";
            }

            else
                WallF.transform.SetParent(wall2.transform);

        }
        wall1.transform.localPosition = Vector3.zero;
        wall2.transform.localPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
