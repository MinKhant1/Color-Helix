using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFragment : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        if (gameObject.tag == "Hit")
            meshRenderer.material.color = GameController.instance.hitColor;
        else
            meshRenderer.material.color = GameController.instance.failColor;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
