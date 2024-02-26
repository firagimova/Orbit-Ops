using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        //next scene
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        //quit game
        
        Application.Quit();
    }

    public void RickRolling()
    {
        //reset scene
        SceneManager.LoadScene(4);
    }
}
