using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactercontroller : MonoBehaviour {
    public float playerSpeed = 4f;
    bool sprinting = false;
    public float playerSprintSpeed;

    void Start()
    {
        playerSprintSpeed = playerSpeed * 2;
    }

    void FixedUpdate()
    {
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if(!sprinting)
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;
        else
            GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSprintSpeed;
        if (Input.GetKeyDown(KeyCode.LeftShift) == true)
        {
            if (sprinting)
                sprinting = false;
            else
                sprinting = true;
        }
        
    }
}
