using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rbody;
    public float zForce = 500f;
    public float yForce = 500f;
    public float xForce = 500f;
    void Start()
    {
        //rbody.useGravity = false;
        //rbody.AddForce(0,200,500);
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            rbody.AddForce(0,0,zForce * Time.deltaTime,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rbody.AddForce(-xForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rbody.AddForce(xForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
    }
}
