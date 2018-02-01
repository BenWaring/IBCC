using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonate1 : MonoBehaviour {

    public int Timer = 5;
	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject,Timer);
	}

}
