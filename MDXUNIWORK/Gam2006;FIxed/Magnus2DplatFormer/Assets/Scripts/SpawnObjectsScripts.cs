using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjectsScripts : MonoBehaviour
{
    GameObject Bullet;
    public int scoreamount;
    int finalamount;
    public float SpawnSpeed = 2f;
    public Text ScoreTXT;
     float countdown = 3.0f;
    public GameObject[] spawnlocations;
    GameObject currentPoint;
    float amountinspawnlocations;
    int index;
    GameObject objectchangelocation;
    public GameObject StartEnemy;

    // Use this for initialization
    void Start ()
    {
        
        spawnlocations = GameObject.FindGameObjectsWithTag("SpawnPoints");
        //Finds objest with the tags spawnpoints
        countdown = SpawnSpeed;
        //amountofnumbers(); code dont work but keep it incase YGM.
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        ScoreCounterText();
        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)
        {


            index = Random.Range(0, spawnlocations.Length);
            //  figures out the amount of objects in spawn locations and then 
            //  selects a random number from the length of the spawn locations.

            currentPoint = spawnlocations[index];
            //didnt fully understand this:: ask penda to explain.

            print(currentPoint.name);
            Debug.Log(currentPoint.name);

            objectchangelocation = Instantiate(StartEnemy, currentPoint.transform.position, Quaternion.identity);
            //creates an object that is from a prefab and changes the location of the object to the one selected from the array.

            //objectchangelocation.transform.position = currentPoint.transform.position;
            countdown = SpawnSpeed;
            FindBullets();
        }
    }
    public void FindBullets()
    {
        Bullet = GameObject.Find("BulletDestroyObject");
        BulletDestroyObject bulletdestroyobjectScript = Bullet.GetComponent<BulletDestroyObject>();
        scoreamount =  bulletdestroyobjectScript.finalscore;
        finalamount = scoreamount;

    }
    public void ScoreCounterText()
    {
        
        ScoreTXT.text = "Score " + finalamount;

    }

    /*void amountofnumbers()
    {
        foreach (GameObject value in spawnlocations)
        {
            print(value);

        }

      */
    
}
