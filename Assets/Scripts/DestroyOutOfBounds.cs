using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Verwijdert objecten als ze buiten het speelgebied zijn.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            //Zegt "Game Over!" in de debug log als een dier de speler raakt.
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
