using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

    public GameObject explosion;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        col.gameObject.GetComponent<Detonate>().Timer =0;
    }
}
