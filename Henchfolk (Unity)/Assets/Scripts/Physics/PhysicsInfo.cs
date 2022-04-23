using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsInfo : MonoBehaviour
{
    public float Velocity;
    public float AngularVelocity;
    public Rigidbody2D theRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        theRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
