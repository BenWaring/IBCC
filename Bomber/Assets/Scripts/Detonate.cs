using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonate : MonoBehaviour {

    public int Timer = 500;
    public GameObject explosion;
	// Use this for initialization
	void Start ()
    {
        //Destroy(gameObject,Timer);

	}

    void Update()
    {
        if (Timer == 0)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            Timer--;
        }
    }
}
