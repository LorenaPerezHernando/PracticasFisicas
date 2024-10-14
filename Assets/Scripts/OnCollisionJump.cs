using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionJump : MonoBehaviour
{
    private int _verticalForce;
    public int minForce;
    public int maxForce;

    private void OnCollisionEnter(Collision collision)
    {
        _verticalForce = Random.Range(minForce, maxForce);
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * _verticalForce);

            Destroy(gameObject, 1);
        }
    }

}
