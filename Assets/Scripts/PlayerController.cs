using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    // Public floats
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    public float fireRate = 0.1f;
    private float nextFire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Houdt speler binnen het speelgebied.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // Schiet appels met de spatiebalk. 
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as GameObject;
        }
        // De speler heen en weer kunnen bewegen met de pijltjes toetsen.
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(speed * horizontalInput * Time.deltaTime * Vector3.right);
    }
}
