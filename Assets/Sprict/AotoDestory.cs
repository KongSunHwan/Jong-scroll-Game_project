using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AotoDestory : MonoBehaviour
{
    public float deadTime;

    void Start()
    {
        Destroy(gameObject, deadTime);
    }
    void Update()
    {
        
    }
}
