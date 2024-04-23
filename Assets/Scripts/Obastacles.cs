using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obastacles : MonoBehaviour
{
    public GameObject victoryScreen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            return;
        }
        // Codice per la vittoria
        if (collision.transform.tag == "Win")
        {
            victoryScreen.SetActive(true);
            Time.timeScale = 0;
            return;
        }
    }

    void Update()
    {
        
    }
}
