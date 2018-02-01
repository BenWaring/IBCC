using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate1 : MonoBehaviour {

    // Use this for initialization

    void Awake()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, 100 * Time.deltaTime,0);
    }
}
