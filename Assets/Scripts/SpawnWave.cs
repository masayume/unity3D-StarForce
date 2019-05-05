using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWave : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject powerUp;
    public float spawnDelay = 1.0f;
    public int numberOfEnemies;

    private int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        enemyCount = numberOfEnemies;
        // Invoke("Spawn", spawnDelay);
        Spawn();
    }

    void Update()
    {
        if (enemyCount == 0)
        {
            if (transform.childCount == 0)
            {
                Instantiate(powerUp, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }

    void Spawn()
    {
        enemyCount--;
        GameObject instance =  Instantiate(objectToSpawn, transform.position, transform.rotation) as GameObject;
        instance.transform.parent = transform;
        if (enemyCount > 0)
        {
            Invoke("Spawn", spawnDelay);
        }
    }



}
