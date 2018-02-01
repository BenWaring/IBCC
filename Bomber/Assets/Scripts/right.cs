using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right : MonoBehaviour
{

    public GameObject camera;

    // Use this for initialization
    void Start()
    {
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.Rotate(0, 0, -0.1f);
    }
}
