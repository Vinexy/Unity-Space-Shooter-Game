using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Movement : MonoBehaviour
{
    Rigidbody physics;
    public float vel;
    void Start()
    {
        physics = GetComponent<Rigidbody>();
        physics.velocity = transform.forward * vel;
    }


    
}
