using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float force;
    public CharacterController controller;
    public DynamicJoystick joy;

    // Update is called once per frame
    void Update()
    {
        float horizontal = DynamicJoystick.instance.Horizontal;// Input.GetAxisRaw("Horizontal");
        float vertical = DynamicJoystick.instance.Vertical; // Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, -0.9f, vertical).normalized;
        if(direction.magnitude >= 0.5f)
        {
            controller.Move(direction * force * Time.deltaTime);
        }
    }
   
}