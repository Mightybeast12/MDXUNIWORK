using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movetowards : MonoBehaviour
{
    public int WhichScene;
    public GameObject ToactivateBool;
   
        void Update()
        {
        if (ToactivateBool.active)
        {
            SceneManager.LoadScene(WhichScene);
        }
       
        }
    
}
