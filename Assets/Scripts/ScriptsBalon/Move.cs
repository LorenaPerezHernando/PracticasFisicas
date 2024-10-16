using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public int horizontalForce;
    [SerializeField] bool isGrounded; 

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Floor")
            isGrounded = true;

        else
            isGrounded = false;

    }
    private void FixedUpdate()
    {
        if(isGrounded)
            rb.AddForce(Vector3.right * horizontalForce);
    }

}
