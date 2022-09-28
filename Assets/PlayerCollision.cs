using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement movement;
   void OnCollisionEnter (Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
        }
   }
}
