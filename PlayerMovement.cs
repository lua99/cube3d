using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float forwardForce, sideForce;
    public float rotationSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
       
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce* Time.deltaTime, 0, 0 ,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        float rotationAmount = rotationSpeed * Time.fixedDeltaTime;
        rb.angularVelocity = Vector3.up * rotationAmount;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false;
            
        }
    }
}
