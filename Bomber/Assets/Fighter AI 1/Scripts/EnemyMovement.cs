using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Enemy;

    public System.Random ran = new System.Random();
    int circuit;




    public Transform target; //the enemy's target
    public int moveSpeed = 100; //move speed
    public int rotationSpeed = 6; //speed of turning
    Collision other;
    Transform myTransform; //current transform data of this enemy
    
    void Awake()
    {
        myTransform = transform; //cache transform data for easy access/preformance
    }
    
    void Start()
    {
        circuit = ran.Next(0, 2);
        Debug.Log(circuit);

        if (circuit == 0)
        {
            target = GameObject.FindWithTag("Border.5").transform;
        }
        if(circuit == 1)
        {
            target = GameObject.FindWithTag("Border.5Y").transform;
        }
    }
    
    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "Border.5")
        {
            target = GameObject.FindWithTag("Border1").transform;
            Debug.Log("Detection");
        }

        if (col.gameObject.name == "Border1")
        {
            target = GameObject.FindWithTag("Border1.5").transform;
            Debug.Log("Detection");
        }

        if (col.gameObject.name == "Border1.5")
        {
         
            target = GameObject.FindWithTag("Border2").transform;
            Debug.Log("Detection2");
        }

        if (col.gameObject.name == "Border2")
        {
           
            target = GameObject.FindWithTag("Border2.5").transform;
            Debug.Log("Detection3");
        }

        if (col.gameObject.name == "Border2.5")
        {
            target = GameObject.FindWithTag("Border3").transform;
            Debug.Log("Detection4");
        }

        if (col.gameObject.name == "Border3")
        {
            target = GameObject.FindWithTag("Border3.5").transform;
            Debug.Log("Detection");
        }

        if (col.gameObject.name == "Border3.5")
        {
            target = GameObject.FindWithTag("Border4").transform;
            Debug.Log("Detection");
        }

        if (col.gameObject.name == "Border4")
        {
            target = GameObject.FindWithTag("Border.5").transform;
            Debug.Log("Detection");
        }

        //////////////////////////////////////////////////////////////////

        if (col.gameObject.name == "Border.5Y")
        {
            target = GameObject.FindWithTag("Border1Y").transform;
            Debug.Log("Detection");
        }

        if (col.gameObject.name == "Border1Y")
        {
            target = GameObject.FindWithTag("Border1.5Y").transform;
            Debug.Log("Detection");
        }

        if (col.gameObject.name == "Border1.5Y")
        {

            target = GameObject.FindWithTag("Border2").transform;
            Debug.Log("Detection2");
        }

        if (circuit == 1)
        {

            if (col.gameObject.name == "Border2")
            {

                target = GameObject.FindWithTag("Border2.5Y").transform;
                Debug.Log("Detection3");
            }
        }

        if (col.gameObject.name == "Border2.5Y")
        {
            target = GameObject.FindWithTag("Border3Y").transform;
            Debug.Log("Detection4");
        }

        if (col.gameObject.name == "Border3Y")
        {
            target = GameObject.FindWithTag("Border3.5Y").transform;
            Debug.Log("Detection");
        }

        if (col.gameObject.name == "Border3.5Y")
        {
            target = GameObject.FindWithTag("Border4").transform;
            Debug.Log("Detection");
        }

        if (circuit == 1)
        {

            if (col.gameObject.name == "Border4")
            {
                target = GameObject.FindWithTag("Border.5Y").transform;
                Debug.Log("Detection");
            }
        }
    }

    

    void Update()
    {
        //rotate to look at the target
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
        
        //move towards the player
        myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
    }
}