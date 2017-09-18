using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Debug.Log("All dogs go to heaven, sir.");
        // the transform.position teleports gameobject to a new position ;)
        //transform.position = new Vector3(3,0,0);
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log("Dog Heaven, sir. It's c o n f i r m e d.");
        //if (Input.GetKey(KeyCode.D))
        //{
        //   transform.Translate(0.1f, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.A))
        //    {
        //    transform.Translate(-0.1f, 0, 0);
        // }
        //if (Input.GetButton("Horizontal"))
        //{
        //    transform.Translate(0.2f, 0, 0);
        //}
        float horizontalInput = Input.GetAxis("Horizontal");

        Debug.Log("VOREzontal input: " + horizontalInput);

        float speed = 0.2f;

        transform.Translate(speed * horizontalInput, 0, 0);

        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(0, 6, 0);
        }
       
    }
}
