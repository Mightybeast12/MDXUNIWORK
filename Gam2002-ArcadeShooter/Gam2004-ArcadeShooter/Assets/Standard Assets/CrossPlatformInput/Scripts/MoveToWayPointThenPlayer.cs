using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWayPointThenPlayer : MonoBehaviour {

    Rigidbody2D RB2D;
    GameObject[] WayPoints;
    Transform PlayerLoc;
    public float howclosetoget;
    private  int Rand;
    Transform[] ListofPoints;

    // Use this for initialization
    void Start () {
        PlayerLoc = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        RB2D = gameObject.GetComponent<Rigidbody2D>();

        WayPoints = GameObject.FindGameObjectsWithTag("WayPoint");
        ListofPoints = new Transform[WayPoints.Length];

       // foreach (GameObject Points in WayPoints)
        for(int WP_index=0; WP_index<WayPoints.Length; WP_index++)
        {

            //ListofPoints =  Points.GetComponent<Transform>();
            ListofPoints[WP_index] = WayPoints[WP_index].transform;

        }

    }
	
	// Update is called once per frame
	void Update () {
        //get a random number index for the array
        Rand = Random.Range(0, WayPoints.Length - 1);
        //
        Movetowaypoint();

    }

    void Movetowaypoint()
    {
        Vector2 currentloc = transform.position;

        //
        //RB2D.AddForce(Vector2.MoveTowards(currentloc, ListofPoints[Rand].position, howclosetoget));
        Vector2 positionTo = ListofPoints[Rand].position;
        Vector2 dir = (positionTo - currentloc).normalized;
        RB2D.AddForce(dir);

        float listofpointstransformx = (ListofPoints[Rand].position.x);
        float listofpointstransformy = (ListofPoints[Rand].position.y);
        float currentx = (transform.position.x);
        float currenty = (transform.position.y);
        //
        if (currentx  <= listofpointstransformx && currenty <= listofpointstransformy)
        {
            MovetoPlayer();
        }

    }

    void MovetoPlayer()
    {
        RB2D.AddForce(Vector2.MoveTowards( transform.position, PlayerLoc.position, howclosetoget));

    }


}
