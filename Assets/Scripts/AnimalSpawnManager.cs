using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    float xRange = 20f;
    float zRange = 20f;
    float startDelay = 2f;
    float reapeatAfter = 1.5f;
    // float delay = .00001f;

    private void Start()
    {
        InvokeRepeating("spawnManager", startDelay, reapeatAfter);
    }
    void Update()
    { /*delay -= Time.deltaTime;
 
       if(delay<=0)
        {
            spwanManager();  //one way to use time to instatiate animals automatically
           
            delay = 2f;
            
        }
        */
         
       

        


        
    }

   void spawnManager()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 0, zRange);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }

 
}
