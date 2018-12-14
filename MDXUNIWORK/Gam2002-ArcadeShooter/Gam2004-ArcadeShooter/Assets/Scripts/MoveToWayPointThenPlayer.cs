using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWayPointThenPlayer : MonoBehaviour {

    Rigidbody2D RB2D;
    GameObject[] WayPoints;
    Transform PlayerLoc;
    public float Speed;
    public float chaseSpeed;
    private  int Rand;
    Transform[] ListofPoints;

    // Use this for initialization
    void Start () {
        PlayerLoc = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        RB2D = gameObject.GetComponent<Rigidbody2D>();

        WayPoints = GameObject.FindGameObjectsWithTag("WayPoint");
        ListofPoints = new Transform[WayPoints.Length ];

       // foreach (GameObject Points in WayPoints)
        for(int WP_index=0; WP_index<WayPoints.Length ; WP_index++)
        {

            //ListofPoints =  Points.GetComponent<Transform>();
            ListofPoints[WP_index] = WayPoints[WP_index].transform;

        }
        //get a random number index for the array
        Rand = Random.Range(0, WayPoints.Length - 1);
        //
        Movetowaypoint();

    }

    void Update()
    {
        float listofpointstransformx = (ListofPoints[Rand].position.x);
        float listofpointstransformy = (ListofPoints[Rand].position.y);
        float currentx = (transform.position.x);
        float currenty = (transform.position.y);
        //
        if (currentx <= listofpointstransformx && currenty <= listofpointstransformy)
        {
            print("now slow down");
            RB2D.velocity = Vector2.zero;
           // MovetoPlayer();
        }
      

    }

    void Movetowaypoint()
    {
        Vector2 currentloc = transform.position;

        //
        //RB2D.AddForce(Vector2.MoveTowards(currentloc, ListofPoints[Rand].position, howclosetoget));
        Vector2 positionTo = ListofPoints[Rand].position;
        Vector2 dir = (positionTo - currentloc).normalized;
        dir = dir * Speed;
         RB2D.AddForce(dir, ForceMode2D.Impulse);

    }

    void MovetoPlayer()
    {
        Vector2 currentloc = transform.position;
        Vector2 positionTo = PlayerLoc.position;
        Vector2 dir = (positionTo - currentloc).normalized;

        //float newSpeed = Speed * Time.deltaTime;
        //RB2D.AddForce(Vector2.MoveTowards( transform.position, PlayerLoc.position, (newSpeed / 10)));
        RB2D.AddForce(dir * chaseSpeed, ForceMode2D.Impulse);

    }


}
