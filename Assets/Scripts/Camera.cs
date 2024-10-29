using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Camera playerCamera;
    public Transform player;
    public float sens;
    float rotX = 0;
    float rotY = 0;   
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens;
        float mouseY = Input.GetAxis("Mouse Y") * sens;

        //keeps track of the player's current rotation
        rotX -= mouseY;
        rotX = Mathf.Clamp(rotX, -90f, 90f);

        //rotates the player model based on what direction the player is looking
        transform.localRotation = Quaternion.Euler(rotX, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
