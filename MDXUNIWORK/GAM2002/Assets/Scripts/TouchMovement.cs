using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour {
    public float MovementSPD = 20f;
    public GameObject Player;
    public Rigidbody2D rb2d;
    public 



	// Use this for initialization
	void Start () {
        rb2d = Player.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {



    }

}
