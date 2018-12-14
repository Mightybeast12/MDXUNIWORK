using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {
    public Rigidbody2D rb;
    public int leftright;

    // Use this for initialization
    void Start()
    {
        rb.AddForce( Vector2.down, ForceMode2D.Impulse);
    }

}
