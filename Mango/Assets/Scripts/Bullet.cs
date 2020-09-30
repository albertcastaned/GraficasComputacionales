﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public float speed = 20;

    void Start()
    {
        Destroy(gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
    }
}
