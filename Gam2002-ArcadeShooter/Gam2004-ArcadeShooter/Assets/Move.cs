using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public Rigidbody2D player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a"))
        {
            player.AddForce(Vector2.left * 10);

        }
        if (Input.GetKey("d"))
        {
            player.AddForce(-Vector2.left * 10);

        }
    }
}
