using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour
{
    public Vector3 Force;
    public Vector3 Acceleration;
    public Vector3 Velocity;
    public int mass;
    public Vector3 midPoint;
    // Start is called before the first frame update
    void Start()
    {
        // Mass of focus
        mass = 100;
        // Coordinates of focus
        midPoint = new Vector3(0, 0, 0);
        // Starting velocity
        Velocity = new Vector3(1, 0);
        // Starting position 
        transform.position = new Vector3(5, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = midPoint - transform.position;
        Force = 7 * (diff / Mathf.Pow(diff.magnitude, 2));
        Acceleration = Force / mass;
        Velocity += Acceleration;
        transform.position += Velocity * Time.deltaTime;
    }
}
