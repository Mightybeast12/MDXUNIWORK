using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour {
    public BossHealthindicatorManager BHM;
    public float amountofdamagetotake;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shotgun" || other.gameObject.tag == "TwoTap"|| other.gameObject.tag == "BoomeRang")
        {
            BHM.Healthindicator.value -= amountofdamagetotake;

        }
    }
}
