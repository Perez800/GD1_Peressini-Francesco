using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    public float speed;
    public Vector2 movementvalue;
    public bool grabPressed;
    Rigidbody2D rb;
    public PlayerControllerDx rightHand;



    // Start is called before the first frame update
    void Start()
    {
        speed = 15f;
        rb = transform.GetChild(0).GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (grabPressed) 
        {
            rb.velocity = Vector2.zero;
            rb.isKinematic = true;
            return;
        }
        rb.isKinematic = false;
        Vector2 movementVector = new Vector2(movementvalue.x, movementvalue.y).normalized * speed;
        if (rightHand.grabPressed)
        {
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = 40;
            movementVector.y = 0;
        }
        rb.velocity = movementVector;
    }


    public void OnMoveSX(InputAction.CallbackContext context)
    {
        movementvalue = context.ReadValue<Vector2>();
    }
    public void OnGrabSX(InputAction.CallbackContext context)
    {
        grabPressed = context.ReadValue<float>() > 0;
    }
}
