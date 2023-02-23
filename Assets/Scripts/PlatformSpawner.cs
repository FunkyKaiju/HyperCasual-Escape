using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField]private GameObject platPreFab;
    [SerializeField]private Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        //start spawning platforms every 2 seconds repeatedly
        Instantiate(platPreFab, spawnPoint.position, Quaternion.identity);
    }


}
