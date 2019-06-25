using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFps : MonoBehaviour
{
    float mouseX;
    float mouseY;

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X");
        mouseY -= Input.GetAxis("Mouse Y");

        if (mouseY > 40)
        {
            mouseY = 40;
        }
        else if (mouseY < -40)
        {
            mouseY = -40;
        }
        Debug.Log(mouseY);
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
