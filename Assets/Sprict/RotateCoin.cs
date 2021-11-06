using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float rotSpeedZ;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, rotSpeedZ * Time.deltaTime);
    }
}
