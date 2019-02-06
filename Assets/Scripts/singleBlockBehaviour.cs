using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleBlockBehaviour : MonoBehaviour {
    public GameObject bloque;
    
    public BallStop deadZone;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Destroy(bloque.gameObject);
            deadZone.sumarPunto();          
        }
        
    }
}
