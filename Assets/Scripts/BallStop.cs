using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallStop : MonoBehaviour {

    public Rigidbody2D ball;
    public BallController ballControl;
    public Text tirosLeftTextQuantity;
   // public singleBlockBehaviour playerBall;
    public SceneChanger sceneChanger;
    public Text scorePlayerText;

    public static int tirosLeftQuantity = 30;
    public static int scorePlayerQuantity = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Colision En Base");
        if (other.gameObject.tag == "Ball")
        {
            //Paramos la bola
            ball.velocity = new Vector2(0f, 0f);
            //Reseteamos el nivel
            //Y seteamos la bola como activa
            ballControl.canInteract = true;
            //Tiros
            tirosLeftQuantity--;
            updateScoreLabel(tirosLeftTextQuantity, tirosLeftQuantity);
            //Score
            updateScoreLabel(scorePlayerText, scorePlayerQuantity);
            CheckScore();

        }
    }

    void CheckScore()
    {
        if (scorePlayerQuantity == 17 && tirosLeftQuantity >= 0) 
        {
            //sceneChanger.ChangeSceneTo();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(tirosLeftQuantity < 0)
        {
            sceneChanger.ChangeSceneTo("LoseScene");
        }
    }
    
    void updateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }

    public void sumarPunto()
    {
        scorePlayerQuantity++;
        Debug.Log(scorePlayerQuantity);
    }
}
