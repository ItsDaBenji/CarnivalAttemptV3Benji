using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMBSpawnCanister : MonoBehaviour
{

    [SerializeField] Transform posOne, posTwo, posThree, posFour, posFive, posSix;

    [SerializeField] List<Transform> spawnpoints = new List<Transform>(); //serialized for debugging purposes

    [SerializeField] GameObject[] canisterPrefabs;

    [SerializeField] float spawnTime;

    private void Start()
    {
        spawnpoints.Add(posOne);
        spawnpoints.Add(posTwo);
        spawnpoints.Add(posThree);
        spawnpoints.Add(posFour);
        spawnpoints.Add(posFive);
        spawnpoints.Add(posSix);

        InvokeRepeating("SpawnCanisterTimer", 1, spawnTime);
    }

    private void SpawnCanisterTimer()
    {
        int randPrefab = Random.Range(0, canisterPrefabs.Length);
        int randPos = Random.Range(0, spawnpoints.Count);
        if(randPos < spawnpoints.Count)
        {
            Instantiate(canisterPrefabs[randPrefab], spawnpoints[randPos].position, Quaternion.Euler(90, 0, 0));
            StartCoroutine(AddPosBack(spawnpoints[randPos]));
            spawnpoints.Remove(spawnpoints[randPos]);
        }
    }

    private IEnumerator AddPosBack(Transform removedPos)
    {
        yield return new WaitForSeconds(spawnTime);
        spawnpoints.Add(removedPos);
    }

}
