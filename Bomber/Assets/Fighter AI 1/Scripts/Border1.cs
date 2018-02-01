using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border1 : MonoBehaviour {

    public GameObject Orbit1;
   public float reActivate1 = 3;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

   public bool justHit = false;

    void OnCollisionEnter(Collision col)
    {
        justHit = true;

        if (col.gameObject.name == "Enemy" || col.gameObject.name == "Enemy(Clone)")
        {
            rb.detectCollisions = false;
            
        }

        
    }

        // Update is called once per frame
        void Update () {

        

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

        //if(GameObject.Find("Border4").GetComponent<Border4>().activeEnemy == false)
        //{
        //   Start();
        //}
    }
}
