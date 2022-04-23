using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stagger : MonoBehaviour
{
    public GameObject player;
    //public CharacterController2D CharacterController;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            //player.KnockedOutOfControl = true;
        }
    }

    //Self Note: I need to find out how to get the 'player' object's CharacterController2D script component, and then get the 'KnockedOutOfControl' variable from there to change in here.
}
