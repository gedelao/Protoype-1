using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    // we're making a variable to store references; here we're getting players
    public GameObject player;

    //cleaner code 
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // this method will update after our vehicle is moved
    void LateUpdate()
    {
        //offest the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
