using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
   [SerializeField] public GameController s_gameController;

    Color[] randomColors = { Color.white, Color.blue, Color.green, Color.red, Color.gray, Color.black, Color.blue, Color.cyan, Color.yellow };

    private void Awake()
    {
        s_gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Color colorElegido = GetComponent<Renderer>().material.color = randomColors[Random.Range(0, randomColors.Length)];
        Debug.Log("Color elegido: " + colorElegido); 
    }
    private void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            s_gameController.puntuacion++;
            Destroy(gameObject);
        }
    }
}
