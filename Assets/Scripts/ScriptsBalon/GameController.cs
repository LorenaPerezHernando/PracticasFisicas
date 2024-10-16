using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int puntuacion;
    [SerializeField] public TextMeshProUGUI t_puntuacion;

    [SerializeField] GameObject prefabJumps;
    public int howManyJumps;
    private int x = 0;
    private int i = 0; 

    [SerializeField] Vector3 playerPosStart;
    [SerializeField] GameObject player;
    public GameObject buttonRestart; 


    private void Start()
    {       
        CreateMoreJumps();
        playerPosStart = GameObject.FindGameObjectWithTag("Player").transform.position;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        t_puntuacion.text = "Puntuación: " + puntuacion;
    }

    private void CreateMoreJumps()
    {
        for (i = 0; i < howManyJumps; i++)
        {
            print("CreateJumps");
            x += 10;
            Vector3 startJump = new Vector3(x, 0, 0);
            Instantiate(prefabJumps, startJump, Quaternion.identity);
        }      
    }

    public void RestartScene()
    {
        player.transform.position = new Vector3(playerPosStart.x, playerPosStart.y + 1, playerPosStart.z);
        buttonRestart.SetActive(false);
        i = 0; x = 0;
        puntuacion = 0; 
        CreateMoreJumps();

    }

}

