using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 15.0f;
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
       // Move the vehicle forward 
       transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       // Turn Vehicle
       transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
       
       
       
    }
}
