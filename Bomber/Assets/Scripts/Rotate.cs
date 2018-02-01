using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResourceManager
{
	public static int ScrollWidth { get { return 15; } }
	public static float ScrollSpeed { get { return 25; } }
	public static float RotateAmount { get { return 10; } }
	public static float RotateSpeed { get { return 100; } }

}
	public class Rotate : MonoBehaviour {
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		RotateCamera();
        

    }
	private void RotateCamera()
	{
		Vector3 origin = Camera.main.transform.eulerAngles;
		Vector3 destination = origin;

		//detect rotation if the Right mouse button is down
		if (Input.GetMouseButton(0))
		{
			destination.x -= Input.GetAxis("Mouse Y") * ResourceManager.RotateAmount;
			destination.y += Input.GetAxis("Mouse X") * ResourceManager.RotateAmount;
		}

		//if a change in position is detected perform the necessary update
		if (destination != origin)
		{
			Camera.main.transform.eulerAngles = Vector3.MoveTowards(origin, destination, Time.deltaTime * ResourceManager.RotateSpeed);
		}
	}
}
