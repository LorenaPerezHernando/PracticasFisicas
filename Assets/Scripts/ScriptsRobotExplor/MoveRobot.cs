using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveRobot : MonoBehaviour
{
    [SerializeField] float speedRotation;
    [SerializeField] Vector3 puntoExplorar;
    [SerializeField] bool seguirExplorando;

    private void Start()
    {
        seguirExplorando = true; 
    }
    void FixedUpdate()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward, Color.black);
        if (Physics.Raycast(transform.position, transform.forward, out hit ))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            print("HIT !" + hit.collider.name);

            if(hit.collider.tag == "Objects")
            {
                seguirExplorando = false;
                Vector3 puntodestino = hit.collider.transform.position;
                puntoExplorar = puntodestino;
            }

            


        }
    }
    private void Update()
    {
        if (seguirExplorando == true)
        {
            print("Explorando");
            transform.Rotate(0, speedRotation * Time.deltaTime, 0);
        }
        else if (seguirExplorando == false)
        {
            print("Objeto detectado");
            //transform.Translate(puntoExplorar * Time.deltaTime);
            transform.position = Vector3.Lerp ( transform.position, puntoExplorar, Time.deltaTime/2);
            if(Vector3.Distance(transform.position, puntoExplorar) < 3)
                seguirExplorando=true;
            
        }


    }
}
