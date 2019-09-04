using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public float spawningPeriod = 5.0f;

    float accumulativeTime = 0f;
    System.Random rng = new System.Random();

    // Update is called once per frame
    void Update()
    {
        accumulativeTime += Time.deltaTime;
        
        if(accumulativeTime >= spawningPeriod)
        {
            accumulativeTime -= spawningPeriod;

            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        bool beyondVerticalBorder = (rng.Next() & 1) == 1;

        if(beyondVerticalBorder)
        {
            bool onTop = (rng.Next() & 1) == 1;

            float posx = (float) rng.NextDouble();
            float posy = onTop ? 1.1f : -0.1f;

            Vector2 pos = Camera.main.ViewportToWorldPoint(new Vector2(posx, posy));

            Instantiate(enemyToSpawn, pos, Quaternion.identity);
        }
        else
        {
            bool onRight = (rng.Next() & 1) == 1;

            float posx = onRight ? 1.1f : -0.1f;
            float posy = (float) rng.NextDouble();

            Vector2 pos = Camera.main.ViewportToWorldPoint(new Vector2(posx, posy));

            Instantiate(enemyToSpawn, pos, Quaternion.identity);
        }
    }
}
