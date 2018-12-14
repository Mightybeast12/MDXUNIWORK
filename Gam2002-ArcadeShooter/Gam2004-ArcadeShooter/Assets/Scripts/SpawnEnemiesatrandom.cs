using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesatrandom : MonoBehaviour {
    public HealthManager HM;
    public Transform[] spawnlocations;
    public GameObject[] Spawnedamount;
    public Transform currentspawn;
    public GameObject Enemytype1;
    public GameObject BossOBJ;
    public bool SpawnBoss;
    private GameObject Spawnheart;
    private int RandomSpawn = 10;
    public int Maxpercentage = 10;
    public GameObject Heart;
    public float cooldown = 2;
    float ogcooldown;
    public float speed = 10f;
    int amountof;
    public int Amountallowedtospawn = 10;
    public bool canspawn;
    bool bossisactive;
	// Use this for initialization
	void Start ()
    {
        ogcooldown += cooldown;
      //  canspawn = false;
	}
    // Update is called once per frame
    void Update()
    {
        if (bossisactive)
        {
            canspawn = true;
        }
        if (HM.amountoflives < 3)
        {
            if (RandomSpawn <= 1)
            {
                Spawnheart = Instantiate(Heart, currentspawn.position, Quaternion.identity);
            }
        }
        Spawnedamount = GameObject.FindGameObjectsWithTag("Enemy");
        RandomSpawn = Random.Range(0, Maxpercentage);
        foreach (Transform spawnables in spawnlocations)
        {
            if (Spawnedamount.Length < Amountallowedtospawn + 1)
            {
                cooldown -= Time.deltaTime;
                if (cooldown <= 0)
                {
                    cooldown += ogcooldown;
                    if (!canspawn)
                    {
                        amountof = Random.Range(0, spawnlocations.Length + 1);
                        currentspawn = spawnlocations[amountof];
                        GameObject enemy2 = Instantiate(Enemytype1, currentspawn.position, Quaternion.Euler(0, 0, 180));
                        // enemy.GetComponent<Rigidbody2D>().AddForce(Vector2.down * speed);
                        print("this is:" + currentspawn);
                    }
                }
                if (SpawnBoss)
                {
                    canspawn = true;
                    Spawnbossclas();
                    SpawnBoss = false;
                }
            }
        }
    }
    public void Spawnbossclas()

    {
        GameObject SpawnedBoss = Instantiate(BossOBJ, transform.position, Quaternion.identity);
        GameObject UIP = GameObject.FindGameObjectWithTag("UIP");


        Transform SpawnedBossTransform = SpawnedBoss.GetComponent<Transform>();
        Transform UIPTransform = UIP.GetComponent<Transform>();
        SpawnedBossTransform.transform.parent = UIPTransform.transform;
        SpawnedBossTransform.localScale = (new Vector3(1, 1, 1));
        SpawnedBossTransform.localPosition = (new Vector3(-91,628, 1));


    }
}
