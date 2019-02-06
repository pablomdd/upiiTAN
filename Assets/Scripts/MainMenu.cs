using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    /*
        // Use this for initialization
        void Start () {

        }

        // Update is called once per frame
        void Update () {
        }
        */
    public SceneChanger sceneChanger;

    public void iniciarPartida()
    {
        SceneManager.LoadScene("LevelTres");

    }

    public void puntuaciones()
    {
        SceneManager.LoadScene("Scores");
    }

    public void configuracion()
    {
    }


    public void irMenu()
    {
        SceneManager.LoadScene("Menu");

    }
}
