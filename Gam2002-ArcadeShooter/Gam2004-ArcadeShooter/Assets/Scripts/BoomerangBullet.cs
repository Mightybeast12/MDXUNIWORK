using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangBullet : MonoBehaviour {
    private Vector3 boomerangStartpos;
    public Transform PlayerCharacter;
    //private Transform currentpositoin;
    //public Transform Bullet;
    public float travelspd;
    private bool movingtotarget;
    private GameObject goingup;
    public Transform Movetowards;

	// Use this for initialization
	void Start () {
        movingtotarget = true;
        boomerangStartpos = transform.position;
        goingup = GameObject.FindGameObjectWithTag("GoingUp");
        goingup.GetComponent<Transform>();
        Movetowards = goingup.transform;
            
    }

    // Update is called once per frame
    void Update() {
        if (movingtotarget)
        {
            transform.position = Vector2.MoveTowards(transform.position, Movetowards.position, travelspd * Time.deltaTime);
        }
        if (transform.position == Movetowards.position)
        {
            movingtotarget = false;
            boomerangStartpos = GameObject.FindGameObjectWithTag("Player").transform.position;
        }
        if (!movingtotarget)
        {
            boomerangStartpos = GameObject.FindGameObjectWithTag("Player").transform.position;
            transform.position = Vector2.MoveTowards(transform.position, boomerangStartpos, travelspd * Time.deltaTime);
            transform.Rotate(0,0,180);
        }
        if (transform.position == boomerangStartpos && !movingtotarget)
        {
            Destroy(gameObject);
        }

       
	}
}
