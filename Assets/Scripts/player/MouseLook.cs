﻿ using System;
 using UnityEngine;
 
 public class MouseLook : MonoBehaviour
 {  

    public Transform playerBody;
    float xRotation = 0f;
    public float mouseSensitivity = 100f;
     void Start ()
     {
        Cursor.lockState = CursorLockMode.Locked;
     }
 
     void Update ()
     {
         float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
         float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

         xRotation -= mouseY;
         xRotation = Mathf.Clamp(xRotation, -90f, 90f);

         transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
         playerBody.Rotate(Vector3.up * mouseX);
     }

     //tsdjfj
 }