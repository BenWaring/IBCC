using UnityEngine;
using System.Collections;

public class npcMovement : MonoBehaviour {
	public float movementSpeed = 1.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * movementSpeed;
	}
}


