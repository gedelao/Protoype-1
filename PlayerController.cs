using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Our private variables

    //we're initializing a variable for the speed 
    private float speed = 5.0f;

    // we're initizalizing a variable for vehicle turns
    private float turnSpeed = 25.0f;

    // we're initiazlizing a variable to allow user to users to move the car left/right
    private float horizontalInput;

    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // having intialized horizontalInput, we got the input of our horizontal/vetical
        horizontalInput = Input.GetAxis("Horizontal");

        forwardInput = Input.GetAxis("Vertical");

        // we'll move the vehicle forward and controlling the time for when it moves
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // We'll be able to turn the vehicle 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
