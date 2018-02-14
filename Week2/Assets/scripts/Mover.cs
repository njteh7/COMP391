using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed;

    private Rigidbody2D rBody;
	// Use this for initialization
	void Start ()
    {
        rBody = this.GetComponent<Rigidbody2D>();
        rBody.velocity = this.transform.right * speed; // set velocity = (1, 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
