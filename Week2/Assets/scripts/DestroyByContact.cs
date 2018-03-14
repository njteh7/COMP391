using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosionAsteroid;
    public GameObject explosionPlayer;
    public int scoreValue = 10;

    private GameController gameControllerScript;

	// Use this for initialization
	void Start ()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        if (gameControllerObject != null)
        {
            gameControllerScript = gameControllerObject.GetComponent<GameController>();
        }

        if (gameControllerScript == null)
        {
            Debug.Log("Cannot find Game Controller script on object");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary")
        {
            return;
            //Debug.Log("DestroyByContact");
        }

        if (other.tag == "Player")
        {
            Vector3 deltaP = (this.transform.position + other.transform.position) / 2;  // Vector between player and astroid
            // deltaP = (other.transform.position + deltaP) / 2; // Find halfway point between both objects
            // Create our explosion animation
            Instantiate(explosionPlayer, other.transform.position, other.transform.rotation);

            // GAME OVER!
            gameControllerScript.GameOver();
        }
        else
        {
            Instantiate(explosionAsteroid, this.transform.position, this.transform.rotation);
            gameControllerScript.AddScore(scoreValue);
        }

        

        Destroy(this.gameObject); // Destroying this thing (laser)
        Destroy(other.gameObject); // Destroying this thing (the astroid)
    }
}
