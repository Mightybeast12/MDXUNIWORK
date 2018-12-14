using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToStartScreen : MonoBehaviour {
    public GameObject Ifactive;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Ifactive.activeSelf)
        {
              SceneManager.LoadScene(0);
            
        }
	}
}
