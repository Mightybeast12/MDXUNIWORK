using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rightbutton : MonoBehaviour {

    private Player player;
    public GameObject RightBool;
    public GameObject LeftBool;

    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!RightBool.activeSelf && !LeftBool.activeSelf)
        {
            player.movedirection = 2;
            // if any of the movement buttons are active the player stops moving 
        }
        if (RightBool.activeSelf | LeftBool.activeSelf)
        {
            if (RightBool.activeSelf)
            {
                player.movedirection = 3;
            }
            if (LeftBool.activeSelf)
            {
                player.movedirection = 1;
            }
        }
        



    }
}
