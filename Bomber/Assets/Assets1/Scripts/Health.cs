using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public float maxPlaneHealth = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(maxPlaneHealth == 0)
		{
			Destroy(gameObject);
		}
	}

	public void takeDamage(float damage)
	{
		maxPlaneHealth -= damage;
	}
}
