using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixCylinder : MonoBehaviour
{

    GameObject helix;
    // Start is called before the first frame update
    void Awake()
    {

        helix = GameObject.Find("Helix");
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, helix.gameObject.transform.eulerAngles.z % 25);
        
    }
}
