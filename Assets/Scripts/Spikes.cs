using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

    // unity calls this function automatically 
    // when our spikes touch any other object 

    private void OnCollisionEnter2D(Collision2D collision)
    {

        // check if the thing that we collided with 
        // is the player (aka has a Player script) 
        Player playerScript = collision.collider.GetComponent<Player>();

        // only do something if the thing we ran into was infact the player
        // aka playerScript is not null 
        if(playerScript != null)
        {
            // we DID hit the player!

            // kill player 
            playerScript.Kill();
        }
    }


}
