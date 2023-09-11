using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharController : MonoBehaviour
{
    NavMeshAgent navMeshAgent;

    public float force;
    public CharacterController controller;
    public DynamicJoystick joy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = DynamicJoystick.instance.Horizontal;
        var y = DynamicJoystick.instance.Vertical;
        Vector3 direction = new Vector3(x, -0.9f, y).normalized;
        if (direction.magnitude >= 0.5f)
        {
            controller.Move(direction * force * Time.deltaTime);
        }
        if (x != 0 || y != 0)
        {
            var moveDirection = new Vector3(x, 0, y);
            var movePosition = transform.position + moveDirection;
        }
        else
        {
            navMeshAgent.SetDestination(transform.position);
        }
    }
}
