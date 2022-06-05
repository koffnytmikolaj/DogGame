using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float timeBetweenSpawn;
    private float spawnTime;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        Instantiate(obstacle, transform.position + new Vector3(randomX, -2.8f, 0), transform.rotation);
    }
}
