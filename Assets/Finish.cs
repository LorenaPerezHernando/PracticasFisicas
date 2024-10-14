using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameController s_gameController;
    [SerializeField] private GameObject[] jumps;

    [SerializeField] private GameObject buttonRestart;

    private void Start()
    {
        s_gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        buttonRestart. SetActive(false);

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {

            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

            s_gameController.t_puntuacion.text = "Fin de la partida, puntuacion: " + s_gameController.puntuacion;
            buttonRestart.SetActive(true);

            jumps = GameObject.FindGameObjectsWithTag("Jumps");
            foreach(GameObject x in jumps)
            {
                Destroy(x);
            }


        }
    }
}
