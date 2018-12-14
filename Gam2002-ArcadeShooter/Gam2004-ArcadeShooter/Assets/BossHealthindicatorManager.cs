using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthindicatorManager : MonoBehaviour {
    public GameObject BossManager;
    public SpawnEnemiesatrandom SER;
    public float BossmaxHealth;
    public Text Health;
    public float amountofhealth;
    public Slider Healthindicator;
	// Use this for initialization
	void Start () {
       
        Healthindicator.maxValue = BossmaxHealth;
        Healthindicator.value = BossmaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        SER = GameObject.FindGameObjectWithTag("SER").GetComponent<SpawnEnemiesatrandom>();
        amountofhealth =  (Healthindicator.value);
        Health.text = BossmaxHealth.ToString()+ "/" +  amountofhealth.ToString();

        if (amountofhealth <= 0)
        {
            Destroy(BossManager);
            SER.SpawnBoss = false;
            SER.canspawn = false;
            
        }
	}

}
