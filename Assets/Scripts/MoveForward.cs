﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Public floats
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    // Laat het projectiel en de dieren naar voren bewegen.
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
