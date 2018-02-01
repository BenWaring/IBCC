using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plane : MonoBehaviour {


    Vector3 movement;
    float soh;
    float coh;
    float PI = 3.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //movement.Set(0,0,0);

        //soh = Mathf.Sin(transform.rotation.eulerAngles.z) * 180 / PI * 0.01f;
        //coh = Mathf.Cos(transform.rotation.eulerAngles.z) * 180 / PI * 0.01f;
        movement.Set(0,0,0.1f);


        transform.position += movement;
	}
}
