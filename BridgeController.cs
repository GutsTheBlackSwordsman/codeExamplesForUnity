using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BridgeController : MonoBehaviour
{
    public List<GameObject> steps = new List<GameObject>();
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddStep();
        }
    }

   

    public void AddStep()
    {
        foreach (var item in steps)
        {
            if (!item.activeSelf)
            {
                item.SetActive(true);
                break;
            }
        }
    }
}
