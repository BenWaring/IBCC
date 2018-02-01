using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border1P5 : MonoBehaviour {

    public GameObject Orbit1;
    float reActivate1 = 3;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    bool justHit = false;

    void OnCollisionEnter(Collision col)
    {
        justHit = true;
        if (col.gameObject.name == "Enemy" || col.gameObject.name == "Enemy(Clone)")
        {
            rb.detectCollisions = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (justHit == true)
        {
            reActivate1 -= Time.deltaTime;
            if (reActivate1 < 0)
            {
                rb.detectCollisions = true;
                justHit = false;
                reActivate1 = 3;
            }
        }
    }
}
