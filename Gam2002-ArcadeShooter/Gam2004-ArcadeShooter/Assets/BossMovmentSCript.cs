using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovmentSCript : MonoBehaviour {
    public Transform BossTranform;
    int rand;
        public float movementspeed;
    public Transform[] waypoints;
    public float Cooldown;
    public float ogcooldown;
    bool Move;
    // Use this for initialization
    void Start () {
        ogcooldown = Cooldown;
    }
	
	// Update is called once per frame
	void Update () {
        Cooldown -= Time.deltaTime;
        if (Cooldown <= 0)
        {
            Move = true;
        }
        if (Move)
        {
            Movetowaypoint();
        }
        BossTranform.position = Vector2.MoveTowards(BossTranform.position, waypoints[rand].position, movementspeed * Time.deltaTime);
    }
    void Movetowaypoint()
    {

         rand = Random.Range(0, waypoints.Length);
       
        Cooldown += ogcooldown;

        Move = false;

    }
}   
