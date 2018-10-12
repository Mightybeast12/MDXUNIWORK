using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerShoot : MonoBehaviour {
    public GameObject Player;
    public GameObject Bulletprefab;
    public Transform SecondbulletTransform;
    private GameObject newBulletprefab;
    public float ShootSPD;
    
    private Transform BulletLoc;
    public float howlongbulletlive;
    public float timer;
    private bool didbulletspawn;
    private bool startcountdown;

	// Use this for initialization
	void Start () {
        
        BulletLoc = Player.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

       

        if (Input.GetKeyDown("f"))
        {
            /*newBulletprefab = Instantiate(Bulletprefab, SecondbulletTransform.transform.position, Quaternion.identity);
            newBulletprefab.GetComponent<Rigidbody2D>().AddForce(Vector2.right * ShootSPD * 100);
            */
            //Spawns anotherobjce

            newBulletprefab = Instantiate(Bulletprefab, BulletLoc.transform.position , Quaternion.identity);
            newBulletprefab.GetComponent<Rigidbody2D>().AddForce(Vector2.right * ShootSPD * 100);
            didbulletspawn = true;
            startcountdown = true;
            if (howlongbulletlive <= 0 && didbulletspawn)
            {                
                didbulletspawn = false;
                howlongbulletlive = timer;
            }
           

        }
        if (startcountdown)
        {
            howlongbulletlive -= Time.deltaTime;
           
        }
        if (howlongbulletlive <= 0)
        {
            
            startcountdown = false;
        }

    }
    

  
}
