using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public Rigidbody2D theRigidbody2D;
    public float thrust = 1f;
    // Start is called before the first frame update
    void Start()
    {
        theRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            theRigidbody2D.AddForce(transform.right * thrust * Time.deltaTime);
        }
    }
}
