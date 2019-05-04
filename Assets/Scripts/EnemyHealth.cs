using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int initialHealth = 10;
    public GameObject hitEffect;
    public GameObject deathEffect;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = initialHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {

        currentHealth--;
        Instantiate(hitEffect, col.transform.position, Quaternion.identity);

        if (currentHealth <= 0)
        {
            Instantiate(deathEffect, col.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
