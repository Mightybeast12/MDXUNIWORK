using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyScript : MonoBehaviour {

    ScoreSystem SS;

    // Use this for initialization
    void Start () {

        SS = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreSystem>();
    }
	

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Enemy"))
        {
           
            Destroy(other.gameObject);
            AddScore();
            
        }

    }

    void AddScore()
    {

        SS.Points++;
    }

}
