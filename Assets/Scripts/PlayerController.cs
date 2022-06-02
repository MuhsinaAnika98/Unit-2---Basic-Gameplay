using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float fixedRange = 10f;
    public float horaizontalInput;
    public float speed;
    public GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        horaizontalInput = Input.GetAxis("Horizontal");
        transform.Translate (Vector3.right * Time.deltaTime * speed * horaizontalInput);

        if(transform.position.x<-fixedRange)
        {

            transform.position = new Vector3(-fixedRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > fixedRange)
        {
            transform.position = new Vector3(fixedRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(obj, transform.position, transform.rotation);
        }
    }
}
