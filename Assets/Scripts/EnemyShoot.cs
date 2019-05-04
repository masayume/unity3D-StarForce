using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public float shotDelay = 1.2f;
    private bool readyToShoot = true;    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Shoot", shotDelay);
    }

    // Update is called once per frame
    void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)) );
        Invoke("Shoot", shotDelay);
        
    }


}
