using System.Collections;
using System.Collections.Generic;
using UnityEngine;

string Variable1 = "Hello ";

public class Geo_Controller : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        string Variable2 = "Word";
        Debug.Log("Hello Word");
        Debug.Log(Variable1 + Variable2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
