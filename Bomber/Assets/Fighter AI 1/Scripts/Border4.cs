using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border4 : MonoBehaviour {

    public GameObject Orbit1;
    float reActivate1 = 3;
    public Rigidbody rb;
    public float enemyDestroy = 7;
    public GameObject spawn;
    public bool activeEnemy = true;
    public GameObject Enemy;
    public bool cloneCreated = true;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    bool justHit = false;
    public int lapCounter = 0;

    void OnCollisionEnter(Collision col)
    {
        justHit = true;
        if (col.gameObject.name == "Enemy" || col.gameObject.name == "Enemy(Clone)")
        {
            lapCounter++;
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

        if(cloneCreated == true)
        {

            if (lapCounter == 2)
            {
                GameObject.Find("Enemy").GetComponent<EnemyMovement>().rotationSpeed = 0;

                enemyDestroy -= Time.deltaTime;
                if (enemyDestroy < 0)
                {
                    GameObject.Find("Enemy").SetActive(false);
                    lapCounter = 0;
                    activeEnemy = false;
                    enemyDestroy = 7;

                }

                if (activeEnemy == false)
                {
                    Instantiate(Enemy, spawn.transform.position, spawn.transform.rotation);
                    activeEnemy = true;
                    cloneCreated = false;
                }
            }
        }

        if (cloneCreated == false)
        {
            if (lapCounter == 2)
            {
                GameObject.Find("Enemy(Clone)").GetComponent<EnemyMovement>().rotationSpeed = 0;

                enemyDestroy -= Time.deltaTime;
                if (enemyDestroy < 0)
                {
                    GameObject.Find("Enemy(Clone)").SetActive(false);
                    lapCounter = 0;
                    activeEnemy = false;
                    enemyDestroy = 7;
                    
                }

                if (activeEnemy == false)
                {
                    Instantiate(Enemy, spawn.transform.position, spawn.transform.rotation);
                    activeEnemy = true;
                    cloneCreated = false;
                }
            }
        }
    }
}


