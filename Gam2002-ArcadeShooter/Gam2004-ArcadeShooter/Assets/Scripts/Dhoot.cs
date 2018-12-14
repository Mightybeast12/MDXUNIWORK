using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dhoot : MonoBehaviour {

    public GameObject shotgunprefab;
    GameObject Bullet;
    public Transform Playerposition;
    public float shootspd = 1;
    private float ogshootspd;
    private float bulletdeathcooldown;
	// Use this for initialization
	void Start () {
        ogshootspd = shootspd;
        bulletdeathcooldown = 20f;
	}
	
	// Update is called once per frame
	void Update () {
        shootspd -= Time.deltaTime;
        if (shootspd <= 0)
        {

           GameObject Bullet =  Instantiate(shotgunprefab, Playerposition.position, Quaternion.identity);
            shootspd += ogshootspd;

        }
        if (bulletdeathcooldown <= 0)
        {
            Destroy(Bullet);
        }
		
	}
}
