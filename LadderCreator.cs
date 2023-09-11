using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderCreator : MonoBehaviour
{
    public GameObject step;
    public int stepCount = 0;
    public Vector3 offset;


    void Start()
    {
        Vector3 startPos = step.transform.position;
        for (int i = 0; i < stepCount; i++)
        {
            Instantiate(step, startPos + offset, Quaternion.identity, transform);
            startPos += offset;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
