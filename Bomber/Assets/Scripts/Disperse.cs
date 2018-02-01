using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disperse : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        transform.rotation = new Quaternion(90f,90f,90f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Renderer>().material.color.a <= 0)
        {
            Destroy(gameObject);
        }
        else
        { 
            transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);
            gameObject.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, 0.009f);
        }
    }


}
