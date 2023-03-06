using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private Transform playerSpawnPoint;
    [SerializeField] private GameObject player;

    public float minX = -1.5f, maxX = 1.5f;

    private void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);

    }
}
