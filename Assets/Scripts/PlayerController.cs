using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    public float speed;
    public float rBoundary = 10f;
    public float lBoundary = -10f;
    public float dBoundary = -2f;
    public Vector2 value;
    //InputAction MoveAction;
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
        //float xMovement = Input.GetAxisRaw("Horizontal");
        //float yMovement = Input.GetAxisRaw("Vertical");
        Vector2 movementVector = new Vector2(value.x, value.y).normalized * speed;
        rb.velocity = movementVector;
        /*if (transform.position.x >= rBoundary)
        {
            transform.position = new Vector2(rBoundary, transform.position.y);
            Debug.Log("snk");
        }
        if (transform.position.x <= lBoundary)
        {
            transform.position = new Vector2(lBoundary, transform.position.y);
            Debug.Log("snk");
        }
        if (transform.position.y <= dBoundary)
        {
            transform.position = new Vector2(transform.position.x, dBoundary);
            Debug.Log("snk");
        }*/
    }


    public void OnMoveSX(InputAction.CallbackContext context)
    {
        value = context.ReadValue<Vector2>();

        Debug.Log(value);
    }
   
}
