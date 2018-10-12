using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform Player;
    
    public float xdistance;
    public float ydistance;
    public float zdistance;


    Vector3 distance;
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        distance = new Vector3(xdistance, ydistance, zdistance);

        transform.position = Player.transform.position + distance;
       
    }
}
