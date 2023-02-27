using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField]private GameObject[] platformPreFabPool;
    [SerializeField]private Transform spawnPoint;

    [SerializeField] private float platformSpawnTimer = 2f;
    private float currentPlatformSpawnTimer;

    public int numberOfPrefabs = 4;

    public float minX = -2f, maxX = 2f;
    public float startTime = 1f, spawnRate = 1f;

    void Start()
    {
        InvokeRepeating("SpawnPlatforms", startTime, spawnRate);
    }

    private void Update()
    {
       
    }

    void SpawnPlatforms()
    {

        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);

        int randomPrefab = Random.Range(0, 4);
       
        Debug.Log("Spawn");
        Instantiate(platformPreFabPool[randomPrefab], temp, Quaternion.identity);
        


    }
}
