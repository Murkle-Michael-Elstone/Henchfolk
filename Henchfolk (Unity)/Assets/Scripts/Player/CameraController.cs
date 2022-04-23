using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /*
    //The player position. Used for focusing back on Krastog during dialogue or when dialogue ends.
    public Transform playerPosition;
    //Eight other focus points for the camera, namely other characters when they speak.
    public float moveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
    /// Target of the camera
    public Transform target;
    public GameObject Player;
    public GameObject Pust;
    public GameObject QwolMar;
    public GameObject Baussa;
    /// Minimum position of camera
    public float minPosition = -5.3f;

    /// Maximum position of camera
    public float maxPosition = 5.3f;

    /// Movement speed of camera
    public float moveSpeed = 1.0f;

    void Start()
    {
        target = Player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        var newPosition = Vector3.Lerp(transform.position, target.position, moveSpeed * Time.deltaTime);

        //newPosition.x = Mathf.Clamp(newPosition.x, minPosition, maxPosition);
        newPosition.x = newPosition.x;
        newPosition.y = newPosition.y;
        newPosition.z = transform.position.z;

        transform.position = newPosition;
    }
}
