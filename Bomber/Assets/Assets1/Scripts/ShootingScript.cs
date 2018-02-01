using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {

	void Start () {
	
	}

	void Update () {



		if (Input.GetMouseButtonDown(0)){       
			//var ray1 = Camera.main.ScreenPointToRay(Input.mousePosition);
			Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
			Transform hitTransform;
			Vector3   hitPoint;
			hitTransform = FindClosestHitObject(ray, out hitPoint);
            
			//Debug.Log (hitTransform.collider.gameObject.name);
			Vector3 forward = transform.TransformDirection(Vector3.forward) * 99999999999;
			Debug.DrawRay(transform.position, forward, Color.green);
		}
	
}


	Health enemyhealth;

	Transform FindClosestHitObject(Ray ray, out Vector3 hitPoint) {
		
		RaycastHit[] hits = Physics.RaycastAll(ray);
		
		Transform closestHit = null;
		float distance = 0;
		hitPoint = Vector3.zero;

		if(hits.Length > 0)
		{
		foreach(RaycastHit hit in hits) {
			if(hit.transform != this.transform && ( closestHit==null || hit.distance < distance ) ) {
				
				closestHit = hit.transform;
				distance = hit.distance;
				hitPoint = hit.point;

					GameObject enemyPlane = hit.collider.gameObject;
					
					if(enemyPlane.tag == "Enemy")
					{
						enemyhealth = enemyPlane.GetComponent<Health>();
						enemyhealth.takeDamage(1);
					}
					
					//Destroy(hit.collider.gameObject);
					
				}
			}
		}

		
		return closestHit;

	}



}
