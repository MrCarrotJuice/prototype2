using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    // public and private floats
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 2;
    private float spawnIntervalA = 3;
    private float spawnIntervalB = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        // Invokes the SpawnRandomBall script.
        Invoke("SpawnRandomBall", startDelay);
        // Sends a message in Debug.Log to see if script launches.
        Debug.Log("Launched");
    }
    
    void Update()
    {
        
    }
    
    void SpawnRandomBall ()
    {
        // Cancels the Invoke
        CancelInvoke();
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // Generates random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        // Instantiates ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        // Invokes SpawnRandomBall again with a random time interval.
        Invoke("SpawnRandomBall", Random.Range(spawnIntervalA, spawnIntervalB));
    }

}