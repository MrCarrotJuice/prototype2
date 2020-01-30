using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    // public floats
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Makes balls and dog move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
