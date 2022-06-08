using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxControl : MonoBehaviour
{
    Rigidbody physics;
    public float vel;
    void Start()
    {
        physics = GetComponent<Rigidbody>();
        physics.velocity = transform.forward*vel;
    }

    
    void Update()
    {
        
    }
}
