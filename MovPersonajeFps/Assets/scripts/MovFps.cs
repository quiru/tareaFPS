using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFps : MonoBehaviour
{
    public float speed = 0.1f;
    float mouseX;

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, mouseX, 0);


        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
    }
}
