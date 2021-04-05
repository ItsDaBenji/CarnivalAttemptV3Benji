using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMBSpawnCanister : MonoBehaviour
{

    [SerializeField] Transform[] spawnpoints;

    [SerializeField] GameObject[] canisterPrefabs;

    [SerializeField] float spawnTime;

    private void Start()
    {
        InvokeRepeating("SpawnCanisterTimer", 1, 10);
    }

    private void SpawnCanisterTimer()
    {
        int randPrefab = Random.Range(0, canisterPrefabs.Length);
        int randPos = Random.Range(0, spawnpoints.Length);
        Instantiate(canisterPrefabs[randPrefab], spawnpoints[randPos].position, Quaternion.Euler(90, 0, 0));
    }

}
