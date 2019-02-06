using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

    public SceneChanger sceneChanger;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static Vector3 ballFinalPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ballFinalPos = collision.GetComponent<BallBehaviour>().transform.position;
        Debug.Log(ballFinalPos);
    }

}
