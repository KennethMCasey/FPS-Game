using UnityEngine;
using System.Collections;

public class TargetBehavior : MonoBehaviour
{

    // target impact on game
    public int scoreAmount;
    public float timeAmount;
    public AudioSource positive;
    public AudioSource negative;

	// explosion when hit?
	public GameObject explosionPrefab;

	// when collided with another gameObject
	void OnCollisionEnter (Collision newCollision)
	{
		// exit if there is a game manager and the game is over
		if (GameManager.gm) {
			if (GameManager.gm.gameIsOver)
				return;
		}

        // only do stuff if hit by a projectile
        if (newCollision.gameObject.tag == "Projectile")
        {
            if (explosionPrefab)
            {
                // Instantiate an explosion effect at the gameObjects position and rotation
                Instantiate(explosionPrefab, transform.position, transform.rotation);
            }

            // if game manager exists, make adjustments based on target properties
            if (GameManager.gm)
            {
                GameManager.gm.targetHit(scoreAmount, timeAmount);
            }

            // destroy the projectile
            Destroy(newCollision.gameObject);

            if (this.gameObject.tag == "TargetBonus" || this.gameObject.tag == "TargetExtraLife") { timer.time += timeAmount; negative.Play(); }
            if (this.gameObject.tag == "TargetPositive" || this.gameObject.tag == "TargetNegative") Points.points += scoreAmount; positive.Play(); }
            
			// destroy self
			Destroy (gameObject);
		}
	}

