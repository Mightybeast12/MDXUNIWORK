using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAliveTImer : MonoBehaviour {
    public GameObject[] foundbullets;
    public float Delay;
    private float Timer = 1f;

    // Use this for initialization
    void Start () {

       
		
	}
    
	
	// Update is called once per frame
	void FixedUpdate () {
        foundbullets = GameObject.FindGameObjectsWithTag("Bullet");

        if (Timer <= 0)
        {
            foundbulletsclass();
            Timer += Delay;

        }
        Timer -= Time.deltaTime;
         
	}

    void foundbulletsclass()
    {

       
        
        foreach (GameObject b in foundbullets)
            //runs for the amount of objects that are in the the foundbulletsarray and renames them to b
        {

            Debug.Log(foundbullets);
            Destroy(b);
            //destroys the gameobjects --b
            

        }

    }

}
