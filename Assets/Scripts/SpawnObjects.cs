using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", spawnDelay);
    }

    void Spawn()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
        Invoke("Spawn", spawnDelay);
    }



}
