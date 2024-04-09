using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obastacles : MonoBehaviour
{
    public GameObject Body;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Obstacle")
        {
            Debug.Log("Game Over");
            Body.SetActive(false);
        }
    }

    void Update()
    {
        
    }
}
