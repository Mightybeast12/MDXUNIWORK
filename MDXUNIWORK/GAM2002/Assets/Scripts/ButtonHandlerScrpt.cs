using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandlerScrpt : MonoBehaviour {
    public GameObject player;
    public PlatformerMovement plyrMv;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonOnePress(int ButtonPressed)
    {
        if (ButtonPressed == 1)
        {
            
            plyrMv.MoveLeftorRight(-1);
        }else if (ButtonPressed == 2)
        {
            print("moved LMAO");
            plyrMv.MoveLeftorRight(1);
        }

    }
}
