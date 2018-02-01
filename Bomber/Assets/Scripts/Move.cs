using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed;
    // Use this for initialization
    void Start()
    {
        speed = 30;
    }

    // Update is called once per frame
    void Update()
    {
        {


            //gameObject.transform.position -= speed * Vector3.forward * Time.deltaTime;
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            gameObject.GetComponent<Rigidbody>().AddForce(30*speed * transform.forward);



            if (Input.GetKey("a"))
            {

                if (transform.rotation.eulerAngles.z > 355 || transform.rotation.eulerAngles.z < 5)
                {
                    transform.Rotate(0, -0.1f, 0.1f);
                    gameObject.transform.position -= speed * Vector3.forward * Time.deltaTime;
                }
                Debug.Log(gameObject.transform.localEulerAngles.z);
                //transform.Translate(new Vector3(-100f * Time.deltaTime, 0, 0));
            }

            if (Input.GetKeyUp("a"))
            {
                transform.Rotate(0, 0, -0.4f);
                Quaternion newrotation = Quaternion.LookRotation(new Vector3(0,0,0));
                newrotation.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y,0);
                gameObject.GetComponent<Rigidbody>().MoveRotation(newrotation);
            }
            //else
            //{
            //    preventStuck();
            //}

            if (Input.GetKey("d"))
            {
                if (transform.rotation.eulerAngles.z > 355 || transform.rotation.eulerAngles.z < 5)
                {
                    transform.Rotate(0, 0.1f, -0.1f);
                }
                //Debug.Log(transform.localEulerAngles.z);
                //transform.Translate(new Vector3(200f * Time.deltaTime, 0, 0));

            }

            if (Input.GetKeyUp("d"))
            {
                transform.Rotate(0, 0, 0.1f);
                //transform.Rotate(0, 0, -0.4f);
                Quaternion newrotation = Quaternion.LookRotation(new Vector3(0, 0, 0));
                newrotation.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
                gameObject.GetComponent<Rigidbody>().MoveRotation(newrotation);
            }

            //else
            //{
            //    preventStuck();
            //}
            if (Input.GetKeyDown("1"))
            {
                speed = 30;
                Debug.Log("fast");
            }

            if (Input.GetKeyDown("2"))
            {
                speed = 15;
                Debug.Log("slow");

            }



        }

    }//end function

    //void preventStuck()
    //{
                                
    //        if (transform.rotation.eulerAngles.z == 355)
    //        {
    //            transform.Rotate(0, 0, 0.3f);
    //        }
    //        if (transform.rotation.eulerAngles.z == 5)
    //        {
    //            transform.Rotate(0, 0, -0.3f);
    //        }
        
    //}

}
