using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] buffPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 30;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float cookieDelay = 10f;
    private float cookieInterval = 15f;

    // Start is called before the first frame update
    void Start()
    {
        /// Spawns the animals on a random interval
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomBuff", cookieDelay, cookieInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Spawns animal on a random coordinate
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    // Spawns the buff cookie
    void SpawnRandomBuff()
    {
        int buffIndex = Random.Range(0, buffPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(buffPrefabs[buffIndex], spawnPos, buffPrefabs[buffIndex].transform.rotation);
    }
}
