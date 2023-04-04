using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    int variable = 10;
    // Start is called before the first frame update
    void Start()
    {
        bool example = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(variable!=10)
        Debug.Log(variable);
    }
}
