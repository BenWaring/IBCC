using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    float speed = 3;

	// Update is called once per frame
	void Update () {
        transform.localPosition += transform.forward * speed * Time.deltaTime;

        


    }
}
