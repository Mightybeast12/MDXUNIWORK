using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDead : MonoBehaviour {
    private ScoreSystem scoresystem;
    public GameObject deathanimation;
    bool startcountdown;
     public float countdown;
	// Use this for initialization
	void Start () {
        scoresystem = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreSystem>();
        
	}
	
	// Update is called once per frame
	void Update () {

        if (startcountdown)
        {
            deathanimation.SetActive(true);
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                scoresystem.Points++;
                Destroy(gameObject);
            }
        }
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("TwoTap") | other.gameObject.tag == ("BoomerRang")| other.gameObject.tag == ("Shotgun"))
        {
            startcountdown = true;

        }

    }
    
}
