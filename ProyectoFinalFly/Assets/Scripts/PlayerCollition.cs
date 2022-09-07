using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollition : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("WayPoint"))
        {
            Debug.Log("collision WayPoint");
            Destroy(other.gameObject);
            GameManager.Score++;
        }
        if (other.gameObject.CompareTag("WayPointSuper"))
        {
            Debug.Log("collision WayPointSuper");
            Destroy(other.gameObject);
            GameManager.Score += 5;
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
          
            Destroy(gameObject);

        }
    }
}
