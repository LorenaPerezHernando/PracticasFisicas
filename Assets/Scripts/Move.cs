using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public int horizontalForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Floor")
        {
            StartMoving();
        }
    }
   public void StartMoving()
    {
        rb.AddForce(Vector3.right * horizontalForce);
    }
}
