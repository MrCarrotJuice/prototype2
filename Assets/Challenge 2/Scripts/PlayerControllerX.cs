using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class PlayerControllerX : MonoBehaviour
 {
     // public and private floats
     public GameObject dogPrefab;
     public float fireRate = 0.5f;
     private float nextFire = 0.0f;
 
     // Update is called once per frame
     void Update()
     {
         // On spacebar press, send a dog to catch the ball. Time between sending dogs is at least 0.5f.
         if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
         {
             nextFire = Time.time + fireRate;
             GameObject clone = Instantiate(dogPrefab, transform.position, transform.rotation) as GameObject;
         }
     }
 }