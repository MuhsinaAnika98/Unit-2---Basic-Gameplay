using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float delay = .00001f;
    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
          //  delay -= Time.deltaTime;
            if(delay<0){

                Instantiate(dogPrefab, transform.position, transform.rotation);
                delay = 5f;

            }

        }
      
       
    }
}
