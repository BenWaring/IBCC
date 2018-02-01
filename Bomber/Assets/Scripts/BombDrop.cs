using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrop : MonoBehaviour {

    public GameObject Bomb;
    public int delay = 500;
    public int current = 500;
	// Use this for initialization
	void Start ()
    {
        enabled = false;
	}
	

    void FixedUpdate ()
    {
        if(current == delay)
        {
            Instantiate(Bomb, transform.position - new Vector3(0, 5, 0), Quaternion.identity);
        }
        if (current == ((delay / 5) * 4)) 
        {
            Instantiate(Bomb, transform.position - new Vector3(0, 5, 0), Quaternion.identity);
        }
        if (current == ((delay / 5) * 3))
        {
            Instantiate(Bomb, transform.position - new Vector3(0, 5, 0), Quaternion.identity);
        }
        if (current == ((delay / 5) * 2))
        {
            Instantiate(Bomb, transform.position - new Vector3(0, 5, 0), Quaternion.identity);
        }
        if (current == ((delay / 5) * 1))
        {
            Instantiate(Bomb, transform.position - new Vector3(0, 5, 0), Quaternion.identity);
        }
        if (current == -100)
        {
            current = delay;
            enabled = false;
        }
        else
        {
            current--;
        }
    }

}
