using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField]private GameObject platformPreFab;
    [SerializeField]private Transform spawnPoint;

    [SerializeField] private float platformSpawnTimer = 2f;
    private float currentPlatformSpawnTimer;

    private int platformSpawnCount;

    public float minX = -2f, maxX = 2f;
    public float minTim = 1f, maxTim = 1f;

    void Start()
    {
        InvokeRepeating("SpawnPlatforms", minTim, maxTim);
    }

    private void Update()
    {
       
    }

    void SpawnPlatforms()
    {
        Debug.Log("Spawning");
        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);
        GameObject newPlatform = null;
        newPlatform = Instantiate(platformPreFab, temp, Quaternion.identity);

    }
}
