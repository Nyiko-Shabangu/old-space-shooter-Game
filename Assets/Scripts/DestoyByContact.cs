using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject PlayerExplosion;
    public int scoreValue;

    private GameController gamecontroller;

      void Start()
    {
       GameObject GameControllerObject = GameObject.FindWithTag("GameController");

        if (GameControllerObject != null)
        {
            gamecontroller = GameControllerObject.GetComponent<GameController>();
        }

        if (gamecontroller == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary")|| other.CompareTag("Enemy"))
        {
            return;
        }

        if (explosion != null)
        {
            Instantiate(explosion, other.transform.position, other.transform.rotation);
        }

        if (other.tag == "Player")
        {
            Instantiate(PlayerExplosion, other.transform.position, other.transform.rotation);
            gamecontroller.GameOver();
        }
        gamecontroller.Addscore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}


	
