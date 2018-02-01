using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, 2000 * Time.deltaTime);

    }
}
