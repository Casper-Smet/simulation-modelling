using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpringD : MonoBehaviour
{   
    public Vector3 Force;
    public Vector3 Acceleration;
    public Vector3 Velocity;
    public int mass;
    public Vector3 startForce;
    // Start is called before the first frame update
    void Start()
    {
        // Starting position
        transform.position = new Vector3(4, 1000);
        mass = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Force = -10 * transform.position - Velocity;
        Acceleration = Force / mass;
        Velocity += Acceleration;
        transform.position += Velocity * Time.deltaTime;
    }
}
