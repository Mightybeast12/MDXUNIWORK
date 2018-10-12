using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyObject : MonoBehaviour
{

    public int Score =1;
    public int finalscore;
   
    bool isdead;

    // Use this for initialization
    void Start ()
    {
      

    }
	
	// Update is called once per frame
	void Update ()
    {
        finalscore = Score;
		
	}
   public  void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.gameObject.tag == "Obstacle")
        {                               
            Debug.Log("GameObject2 collided with " + Other.name);
            Score++;
            Destroy(Other.gameObject);
        }

    }
}
