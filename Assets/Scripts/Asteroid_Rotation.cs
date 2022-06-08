using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Rotation : MonoBehaviour
{
    Rigidbody physics;
    public float vel;
    void Start()
    {
        physics = GetComponent<Rigidbody>();
        physics.angularVelocity = Random.insideUnitSphere*vel;
    }

    
    
}
