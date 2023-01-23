using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class GameOver : MonoBehaviour
{
    GameObject play;
    GameObject htp;
    GameObject tutorial;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        play = GameObject.Find("Play Again");
        htp = GameObject.Find("Main Menu");
        tutorial = GameObject.Find("Quit");
    }
    public void NextScene()
    {
        SceneManager.LoadScene("GameStart");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuDesign2");
    }
    public void Leave()
    {
        Application.Quit();
    }
}
