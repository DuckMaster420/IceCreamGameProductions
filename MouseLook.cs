using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;

    public float mouseSensitivity = 3;

    public Transform playerBody;

    private float playerRotation = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        playerRotation = Input.GetAxis("Mouse Y");

        transform.eulerAngles = (Vector2)rotation * mouseSensitivity;
        rotation.x = Mathf.Clamp(rotation.x, -25, 25);
    }
}