using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leftbutton : MonoBehaviour {

    private Player player;
    public GameObject LeftBool;
    
	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {

        if (LeftBool.active)
        {
            player.movedirection = 0;
        }
        
            
        
	}
}
