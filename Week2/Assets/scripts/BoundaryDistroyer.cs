using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDistroyer : MonoBehaviour {
    /*
    // Runs when an object first enters into a collider zone
    // Runs once!
	void OnTriggerEntry2D(Collider2D other)
    {

    }
    // Runs whenevers an object is inside a collider
    // Runs every frame
    void OnTriggerStay2D(Collider2D other)
    {

    }
    */

    // Runs whenever an object exits the collider zone
    // Runs once
    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
