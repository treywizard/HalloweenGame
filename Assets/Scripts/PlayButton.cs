using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
public class PlayButton : MonoBehaviour
{
    GameObject play;
    GameObject htp;
    GameObject tutorial;
    GameObject back;
    GameObject quit;
    void Start()
    {
       play = GameObject.Find("Play");
       htp = GameObject.Find("How to Play");
       tutorial = GameObject.Find("Tutorial");
       back = GameObject.Find("Back");
       //tutorial.SetActive(false);
       //back.SetActive(false);
       quit = GameObject.Find("Quit");
    }
    public void NextScene()
    {
        SceneManager.LoadScene("GameStart");
    }
    public void HowToPlay()
    {
         GameObject.Find("Main Camera (1)").transform.position = new Vector3(25.45f, -13.53f, -12.9f);
         play.SetActive(false);
         htp.SetActive(false);
         tutorial.SetActive(true);
        back.SetActive(true);
            quit.SetActive(false);
    }
    public void BackButton()
    {
         GameObject.Find("Main Camera (1)").transform.position = new Vector3(-1.9f, -14.153f, -10.0f);
         play.SetActive(true);
         htp.SetActive(true);
         tutorial.SetActive(false);
         back.SetActive(false);
         quit.SetActive(true);
    }
    public void Leave()
    {
        Application.Quit();
    }
}
