using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootQ : MonoBehaviour
{
    public GameObject bullet;
    public float shotDelay = 0.2f;
    private bool readyToShoot = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && readyToShoot)
        {

            Instantiate(bullet, transform.position + (Vector3.up * 0.2f), transform.rotation * Quaternion.Euler(90f, 0, 0));
            readyToShoot = false;
            Invoke("ResetReadyToShoot", shotDelay);
        }
    }

    void ResetReadyToShoot()
    {
        readyToShoot = true;
    }


}
