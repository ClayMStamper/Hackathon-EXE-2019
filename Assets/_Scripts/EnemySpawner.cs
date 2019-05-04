using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int minTimeBetweenSpawn = 4;
    [SerializeField] private int maxTimeBetweenSpawn = 10;
    [SerializeField] private GameObject enemyToSpawn;
    private float nextSpawnTime = 0f;
    private int timeBetweenSpawns;

    // Update is called once per frame
    void Update()
    {
       
        if (Time.time > nextSpawnTime)
        {
            timeBetweenSpawns = Random.Range(minTimeBetweenSpawn, maxTimeBetweenSpawn);
            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
            nextSpawnTime += timeBetweenSpawns;
            //Debug.Log(timeBetweenSpawns);
        }
    }
}
