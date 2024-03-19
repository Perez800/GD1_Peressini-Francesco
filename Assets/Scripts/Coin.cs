using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    PlayerController playerController;
    private void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.transform.tag == "Player")
        {
            playerController.score += 1;
            Debug.Log("Punti: " + playerController.score);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
