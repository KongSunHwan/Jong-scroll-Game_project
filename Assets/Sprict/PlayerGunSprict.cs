﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunSprict : MonoBehaviour
{
    public GameObject bullet;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
