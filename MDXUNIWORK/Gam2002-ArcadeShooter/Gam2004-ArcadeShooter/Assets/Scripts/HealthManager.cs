using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public int amountoflives = 3;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (amountoflives >= 3)
        {
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
        }
       
        if (amountoflives == 2)
        {
            Heart3.SetActive(false);
            Heart2.SetActive(true);
            Heart1.SetActive(true);

        }
        if (amountoflives == 1)
        {
            Heart3.SetActive(false);
            Heart2.SetActive(false);
            Heart1.SetActive(true);
        }
        if (amountoflives <= 0)
        {
            Heart3.SetActive(false);
            Heart2.SetActive(false);
            Heart1.SetActive(false);

            // SceneManager.LoadScene(0);
        }


    }
}
