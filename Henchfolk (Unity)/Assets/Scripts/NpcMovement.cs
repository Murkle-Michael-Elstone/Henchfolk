using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    public bool moveLeft;
    public bool moveRight;
    public bool hop;
    public Vector2 warpTarget;
    // Start is called before the first frame update
    void Start()
    {
        moveLeft = false;
        moveRight = false;
        hop = false;
        warpTarget = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
