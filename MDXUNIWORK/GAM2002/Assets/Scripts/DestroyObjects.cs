using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{

    public GameObject bullet;
    private GameObject currentbullet;
    GameObject ammo;
    public Transform startlocation;
    public float currentbulletstofire = 0f;
    public float collectedbullets;
    public float shootspeed;
    public float timebeforefire;
    public float amountoftimebeforefire;

    public float startbullets = 0f;

    // Use this for initialization
    void Start()
    {

        print("go");

    }

    // Update is called once per frame
    void Update()
    {
        timebeforefire -= Time.deltaTime;
        if (timebeforefire <= 0.0f)
        {

            if (currentbulletstofire >= 0)
            {
                print("shoot");
                currentbullet = Instantiate(bullet, startlocation.position, Quaternion.identity);
                currentbullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * shootspeed);


                currentbulletstofire -= 1;
            }

            timebeforefire = amountoftimebeforefire;
        }



    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            currentbulletstofire++;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            Destroy(col.gameObject);
            currentbulletstofire++;
            Debug.Log("GameObject2 collided with " + col.name);
        }
        
    }
}
