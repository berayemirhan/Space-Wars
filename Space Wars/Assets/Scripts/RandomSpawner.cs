using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] SpawnPoınts;
    public GameObject[] EnemyPrefebs;
    public float sayac;

    void Start()
    {
        
    }

    
    void Update()
    {
        sayac -= Time.deltaTime;
        if (sayac<=0)
        {
            sayac = 3f;
            int RandEnemy = Random.Range(0, EnemyPrefebs.Length);
            int RandSpawnPoint = Random.Range(0, SpawnPoınts.Length);

            Instantiate(EnemyPrefebs[0], SpawnPoınts[RandSpawnPoint].position, transform.rotation);

        }
    }
}
