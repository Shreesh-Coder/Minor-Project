using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyThroughCam : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float translationSpeed = 1;

   // Update is called once per frame
    void Update()
    {
        //WASD translation
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward / 50 * translationSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left / 50 * translationSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back / 50 * translationSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right / 50 * translationSpeed, Space.Self);
        }

        //arrow key rotation
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(Vector3.up, rotationSpeed / 50);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(Vector3.up, -rotationSpeed / 50);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right, -rotationSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.right, rotationSpeed);
        }
    }
}
