using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackinTimer : MonoBehaviour {
    public Transform player;
    public GameObject Seeobjifactive;
    int gobackfloat;
    int index;
    public bool MoveBack;
    public Vector2[] whereplayerbeen;
    public Vector2[] btcecwhereplayerbeen;
    public int maxamounttotrack;
	// Use this for initialization
	void Start ()
    {
        whereplayerbeen = new Vector2[maxamounttotrack];
        btcecwhereplayerbeen = whereplayerbeen;
	}

    // Update is called once per frame
    void Update()
    {
        if (Seeobjifactive.active)
        {
            MoveBack = true;
            player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        if (!Seeobjifactive.active)
        {
            MoveBack = false;
        }


     

        if (!MoveBack)
        {
            if (index == maxamounttotrack - 1)
            {
                btcecwhereplayerbeen = whereplayerbeen;
                for (int i = 0; i < whereplayerbeen.Length - 1; i++)
                {
                    whereplayerbeen[i] = btcecwhereplayerbeen[i + 1];
                }
                //add new one
            }
            else
            {
                index++;
                // add on the index unitl 9 
            }
            whereplayerbeen[index] = player.position;
        }
        if (MoveBack)
        {
            player.position = btcecwhereplayerbeen[index];
            index--;
            // moves back on the index/array
        }
        else
        {
            MoveBack = false;
        }
        
    }
}
