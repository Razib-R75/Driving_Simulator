using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIstoryoutofbound : MonoBehaviour
{
    private float Bound = 30.0f; 
    private float Bound1 = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > Bound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < Bound1)
        {
            Destroy(gameObject);
        }
    }
}
