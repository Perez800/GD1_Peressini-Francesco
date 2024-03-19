using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float cameraSpeed;
    void Update()
    {
        transform.Translate(Vector2.up * cameraSpeed * Time.deltaTime);
    }
}
