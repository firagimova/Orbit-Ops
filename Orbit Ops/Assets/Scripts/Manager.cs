using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    GameObject[] players;

    public GameObject pl1;
    public GameObject pl2;

    public TextMeshProUGUI hp1;
    public TextMeshProUGUI hp2;

    public TextMeshProUGUI point1;
    public TextMeshProUGUI point2;

    //AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //get all objects with tag "Player"
        players = GameObject.FindGameObjectsWithTag("Player");
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        //if there are no players left, end the game
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            //load game over scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }

        //if the players are not null, update the UI
        if (pl1 != null)
        {
            hp1.text = pl1.GetComponent<Player>().health.ToString();
            
        }
        if (pl2 != null)
        {
            
            hp2.text = pl2.GetComponent<Player2>().health.ToString();
        }

        //if the players are not null, update the UI
        if (pl1 != null)
        {
            point1.text = pl1.GetComponent<Player>().points.ToString();
        }
        if (pl2 != null)
        {
            point2.text = pl2.GetComponent<Player2>().points.ToString();
        }

        //if (pl1 == null || pl2 == null)
        //{
        //    audioSource.Play();
        //}
        
       

    }
}
