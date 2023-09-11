using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepJumper : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerJumper playerJumper = other.GetComponent<PlayerJumper>();
        if (playerJumper != null)
        {
            playerJumper.PlayerJump();
        }
    }
}
