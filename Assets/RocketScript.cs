using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketScript : MonoBehaviour
{

    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))  //Thrust - Go up with the rocket (Z AXIS)
        {
            rigidBody.AddRelativeForce(Vector3.up); 
           
        }
        if (Input.GetKey(KeyCode.A)) // Go left with the rocket - rotate
        {
            transform.Rotate(Vector3.forward); 
        }
        else if (Input.GetKey(KeyCode.D)) // Go right with the rocket - rotate  
        {
            transform.Rotate(-Vector3.forward);
        }
        
    }
    void OnCollisionEnter(Collision exampleCol)
    {
        if (exampleCol.collider.tag == "ground")
        {
            // When collide - restart
            SceneManager.LoadScene("SampleScene");
        }
        

    }
}
