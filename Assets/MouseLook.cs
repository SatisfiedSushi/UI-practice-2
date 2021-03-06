﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;
    public Transform gameObjectToMove;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        if (Input.GetKeyDown("left shift"))
        {
            gameObjectToMove.transform.position = new Vector3(gameObjectToMove.position.x,  gameObjectToMove.position.y - (float)0.2, gameObjectToMove.position.z);
        }
        
        if (Input.GetKeyUp("left shift"))
        {
            gameObjectToMove.transform.position = new Vector3(gameObjectToMove.position.x, gameObjectToMove.position.y + (float)0.2, gameObjectToMove.position.z);
        }
    }
}
