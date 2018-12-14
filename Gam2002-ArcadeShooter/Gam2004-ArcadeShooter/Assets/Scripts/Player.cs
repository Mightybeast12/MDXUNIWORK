using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D Rb;
    public int  movedirection;
    public float movespeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
        if (Input.GetKey("a") | movedirection == 1)
        {
         

            Rb.AddForce(Vector2.left * movespeed * 10);
        }
      
        if (Input.GetKey("d") | movedirection == 3)
        {
            
            Rb.AddForce(Vector2.right * movespeed * 5);
        }
        if (movedirection == 2)
        {
            Rb.velocity = Vector2.zero;
        }



    }
}
