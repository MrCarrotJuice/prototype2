using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Public/private floats
    public GameObject[] animalPrefabs;
    private float SpawnRangeX = 20;
    private float SpawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 2;
    // Start is called before the first frame update
    void Start()
    {
        //Laat de dieren automatisch spawnen zonder dat de speler daar een input voor moet geven.
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        //Laat alle dieren willekeurig spawnen binnen het speelgebied.
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}