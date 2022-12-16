using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //we're initializing a variable for the speed 
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // we'll move the vehicle forward and controlling the time for when it moves
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
