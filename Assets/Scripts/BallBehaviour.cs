using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BallBehaviour : MonoBehaviour {
    public Transform personaje;
    // Use this for initialization
    public Rigidbody2D rbBall;
    public bool gameStarted = false;
    public AudioSource ballAudio;

    public GameObject tilemapGameObject;
    Tilemap tilemap;

    void Start () {
     /*   if (tilemapGameObject != null)
        {
            tilemap = tilemapGameObject.GetComponent<Tilemap>();
        }
    */
    }
	
	// Update is called once per frame
	void Update () {
        if (gameStarted == false)
        {
            //transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);
            if (Input.GetMouseButtonDown(0))
            {
                rbBall.velocity = new Vector2(8, 8);
                gameStarted = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ballAudio.Play();

        Vector3 hitPosition = Vector3.zero;
        if (tilemap != null && tilemapGameObject == collision.gameObject)
        {
            foreach (ContactPoint2D hit in collision.contacts)
            {
                //hitPosition.x = hit.point.x - 0.01f * hit.normal.x;
                //hitPosition.y = hit.point.y - 0.01f * hit.normal.y;
                tilemap.SetTile(tilemap.WorldToCell(hitPosition), null);
            }
        }
    }

}
