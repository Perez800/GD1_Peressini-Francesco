using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
       //if (collision.transform.tag == "Player")
       // {
       //     collision.GetComponent<PlayerController>().score += 1;
       //     score = collision.GetComponent<PlayerController>().score;
       //     Debug.Log("Punti: " + score);
       //     Destroy(gameObject);
       // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
