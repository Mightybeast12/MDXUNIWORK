using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour {

    private HealthManager healthmanager;
    // Use this for initialization
    void Start()
    {

        healthmanager = GameObject.FindGameObjectWithTag("HealthManager").GetComponent<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            healthmanager.amountoflives++;
        }
    }
}
