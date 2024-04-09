using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerDx : MonoBehaviour
{
    public int score = 0;
    public float speed;
    public Vector2 value;
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
        Vector2 movementVector = new Vector2(value.x, value.y).normalized * speed;
        rb.velocity = movementVector;
    }


    public void OnMoveDX(InputAction.CallbackContext context)
    {
        value = context.ReadValue<Vector2>();
        Debug.Log(value);
    }

}
