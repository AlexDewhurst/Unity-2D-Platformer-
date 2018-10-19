using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    private Rigidbody m_rb;


	// Use this for initialization
	void Start () {
        m_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        /* Get user input to add a left-right force (horizontal) to our player object
        */
        //get user input
        float movement = Input.GetAxis("Horizontal");
        //add force
        m_rb.AddForce(new Vector3(movement, 0.0F, 0.0F));
    }
}
