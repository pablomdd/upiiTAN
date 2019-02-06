using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
	public Transform personaje;

 bool gameStarted = false;
 public Rigidbody2D rgBall;

void Start()
{
   
  
}

void Update()
{
    if (!gameStarted)
    {
        float positionDiff = personaje.position.x - transform.position.x;
        transform.position = new Vector3(personaje.position.x -
                    positionDiff, personaje.position.y, personaje.position.z);

        if (Input.GetMouseButtonDown(0))
        {

                rgBall.velocity =new  Vector2(-5, 10);
            gameStarted = true;
        }
    }
}
}