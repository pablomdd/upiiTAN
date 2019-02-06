using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloqueBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public GameObject bloque;

    // Update is called once per frame
    void Update () {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(bloque.gameObject);
       /* var tilePos = tilemap.WorldToCell(collision.gameObject.transform.position);
        Debug.Log("location:" + tilePos);
        tilemap.SetTile(tilePos, null);
        tilemap.SetTile(new Vector3Int(tilePos.x, tilePos.y, tilePos.z), null);
        */
    }
}
