using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour {

    public GameObject Player;
    private Rigidbody2D PlayerRBD;
    private bool jumped;
    private float jumpcooldown;
    public float cooldown;
    public float XSpD = 30;
    public float YSpD = 30;

	// Use this for initialization
	void Start () {

        PlayerRBD = Player.GetComponent<Rigidbody2D>();
        jumped = false;

        	
	}
	
	// Update is called once per frame
	void Update () {
        jumpcooldown -= Time.deltaTime;
        if (jumpcooldown <= 0)
        {
            jumped = true;
        }
        if (Input.GetKey("a"))
        {

           // Quaternion r = Quaternion.Euler(new Vector3(0, 180, 0));

          //  Player.transform.Rotate(0, 180, 0);
            Player.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            PlayerRBD.AddForce(Vector2.left * XSpD * 100 * Time.deltaTime);
           // print("a");
        }
        if (Input.GetKey("d"))
        {
           // Player.transform.Rotate(0, 0, 0);
            Player.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            PlayerRBD.AddForce(Vector2.right * XSpD * 100 * Time.deltaTime);
           // print("d");
        }
        if (Input.GetButtonDown("Jump") && jumped)
        {           
            PlayerRBD.AddForce(Vector2.up * YSpD * 100* Time.deltaTime);
            jumpcooldown = cooldown;
            jumped = false;

        }



    }
    public void MoveLeftorRight(int directionOfMovement)
    {
        if (directionOfMovement>0)
        {
            PlayerRBD.AddForce(Vector2.right * XSpD * 1000 * Time.deltaTime);
            print("right");
        }
        else if (directionOfMovement<0)
        {
            PlayerRBD.AddForce(Vector2.left * XSpD * 1000 * Time.deltaTime);
            print("left");
        }
    }
    public void leftbool(bool leftmove)
    {
        if (leftmove)
        {
            PlayerRBD.AddForce(Vector2.left * XSpD * 1000 * Time.deltaTime);
            print("left");
        }
    }
}
