using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeuUnlock : MonoBehaviour {

    public GameObject unlcokobj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

        
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Key")
        {
            Debug.Log(other);
            unlcokobj.SetActive(true);

        }
    }
}
