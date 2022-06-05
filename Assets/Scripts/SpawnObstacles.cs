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
    private Dog dog;
    [SerializeField] GameObject player;
    [SerializeField] GameObject gameManager;

    void Awake()
    {
        dog = player.GetComponent<Dog>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!dog.dead && Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        Vector3 spawnPosition;
        float randomX, distance;
        float gamePositionFactor = 0.6f * Mathf.Min(1 + gameManager.transform.position.x / 1000, 2f);
        bool repeat;
        do
        {
            repeat = false;
            randomX = Random.Range(minX, maxX);
            spawnPosition = transform.position + new Vector3(randomX, -2.8f, 0);
            
            foreach (GameObject obs in GameObject.FindGameObjectsWithTag("Obstacle"))
            {
                distance = Mathf.Abs(obs.transform.position.x - spawnPosition.x);
                if (distance >= 3 * gamePositionFactor && distance <= 15 * gamePositionFactor)
                {
                    repeat = true;
                    break;
                }
            }
        } while (repeat);
        Instantiate(obstacle, spawnPosition, transform.rotation);
    }
}
