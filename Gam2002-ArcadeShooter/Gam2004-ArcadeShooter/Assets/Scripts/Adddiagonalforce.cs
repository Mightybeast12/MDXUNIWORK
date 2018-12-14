using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adddiagonalforce : MonoBehaviour {
    public Rigidbody2D rb;
    public int leftright;

	// Use this for initialization
	void Start () {
        rb.AddForce( new Vector2 (leftright ,30), ForceMode2D.Impulse );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
