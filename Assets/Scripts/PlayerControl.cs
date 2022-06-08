using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody physics;
    float horizontal=0;
    float vertical=0;
    Vector3 vec;
    public float vel;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float slope;
    float firetime=0;
    public float firetiming;
    public GameObject bullet;
    public Transform WBulletOut;
    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time>firetime)
        {
            firetime = Time.time + firetiming;
            Instantiate(bullet, WBulletOut.position,Quaternion.identity);
           

        }
    }


    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        vec = new Vector3(horizontal,0,vertical);
        physics.velocity = vec*vel;
        physics.position = new Vector3
            (
            Mathf.Clamp(physics.position.x, minX, maxX),
            0.0f,
            Mathf.Clamp(physics.position.z, minZ, maxZ)
            );
        physics.rotation = Quaternion.Euler(0, 0, physics.velocity.x*-slope);

    }

}