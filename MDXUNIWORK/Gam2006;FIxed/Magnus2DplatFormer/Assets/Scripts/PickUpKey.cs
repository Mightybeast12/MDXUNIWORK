using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour {
    public GameObject playerhand;
    public GameObject rangeindicator;
        
    private Rigidbody2D playerrb2d;
	// Use this for initialization
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Key")  )
        {
            rangeindicator.SetActive(true);
            if (Input.GetKey("g"))
            {
                
                other.transform.position = playerhand.transform.position;
            }
            

        }
    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == ("Key"))
        {
           
            rangeindicator.SetActive(false);
        }
    }
}
