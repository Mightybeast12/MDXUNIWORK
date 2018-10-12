using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public GameObject player;
    private Rigidbody2D personalrigidbody;
    

	// Use this for initialization
	void Start () {
        personalrigidbody = player.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("a"))
        {
            personalrigidbody.AddForce(Vector2.left * 300* Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            personalrigidbody.AddForce(Vector2.right *300 * Time.deltaTime);
        }
    }
}
