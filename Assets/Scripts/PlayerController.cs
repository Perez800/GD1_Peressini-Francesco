using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    public float speed;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        speed = 15f;

        rb = transform.GetChild(0).GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        float yMovement = Input.GetAxisRaw("Vertical");
        Vector2 movementVector = new Vector2(xMovement, yMovement).normalized;
        //transform.Translate(movementVector * speed * Time.deltaTime);
        //Debug.Log(xMovement);

        rb.velocity = movementVector;
    }
}
