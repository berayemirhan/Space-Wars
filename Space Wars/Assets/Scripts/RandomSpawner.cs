using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] SpawnPoınts;
    public GameObject[] EnemyPrefebs;
    public  float sayac;

    void Start()
    {
        sayac = 0;
    }

    
    void Update()
    {
        sayac -= Time.deltaTime;
        if (sayac<=0)
        {
            if(score.puan >= 100)
            {
                sayac = 0.5f;

            }
            
            else if(score.puan >= 60)
            {
                sayac = 1f;
            }
            else if(score.puan>=30)
            {
                sayac = 1.5f;
            }
            else
            {
                sayac = 2f;
            }
            
            int RandEnemy = Random.Range(0, EnemyPrefebs.Length);
            int RandSpawnPoint = Random.Range(0, SpawnPoınts.Length);

            Instantiate(EnemyPrefebs[0], SpawnPoınts[RandSpawnPoint].position, transform.rotation);

        }
        
    }
}
