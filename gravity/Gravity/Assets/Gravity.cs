using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Vector3 Force;
    public Vector3 Acceleration;
    public Vector3 Velocity;
    public int mass;
    public Vector3 startForce;
    // Start is called before the first frame update
    void Start()
    {
        // Downward force
        Force = new Vector3(0, -1, 0);
        mass = 10;
        // Starting position (0, 1000, 0)
        transform.position = new Vector3(0, 1000);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Acceleration = Force / mass;
        Velocity += Acceleration;
        transform.position += Velocity * Time.deltaTime;
    }
}
