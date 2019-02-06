using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikachuMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        Vector3 mousepos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
    transform.position =new Vector3(Mathf.Clamp(mousepos.x,2.15f,2.15f),transform.position.y,transform.position.z);
	}
}
