using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
 float lower_range = 14f;
    float upper_range = 30f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z<-lower_range)
        {

            Destroy(gameObject);
        }

        else if (transform.position.z >upper_range)
        {

            Destroy(gameObject);
        }
      
    }
}
