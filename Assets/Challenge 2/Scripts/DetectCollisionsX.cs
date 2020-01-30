using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    // Destroys balls when they touch the hitbox of the dog prefab.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
