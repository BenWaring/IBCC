using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Align : MonoBehaviour {

    // Use this for initialization
    public int count = 18;
    public int rotateAmount = 5;
	void Start ()
    {
        transform.Rotate(-90, 0, 0);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (count != 0)
        {
            transform.Rotate(+rotateAmount, 0, 0);
            count--;
        }
        else
        {
            transform.Rotate(0,100*Time.deltaTime,0);
            //enabled = false;
        }
    }
}
