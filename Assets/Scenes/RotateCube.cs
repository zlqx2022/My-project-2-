using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    // Start is called before the first frame update
    private float angles;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.rotation = Quaternion.Euler(0,angles++,0);
    }
}
