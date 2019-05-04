using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekingMissile : MonoBehaviour
{
    public float initialVelocity = 10.0f;
    public float missileAccelerationForce = 10.0f;
    public float maxVelocity = 10.0f;
    private float maxSqrVelocity;
    private Rigidbody rb;
    private GameObject nearestEnemy;

    // Start is called before the first frame update
    void Start()
    {

        rb = this.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * initialVelocity, ForceMode.VelocityChange);
        float nearestDistance = Mathf.Infinity;
        nearestEnemy = null;
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Enemies"))
        {
            float distance = (transform.position - obj.transform.position).sqrMagnitude;
            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestEnemy = obj;
            }

        }
        maxSqrVelocity = maxVelocity * maxVelocity;
    }

    // Update is called once per frame
    void FixedUpdate()   // physics
    {
        if (nearestEnemy != null)
        {
            transform.rotation = Quaternion.LookRotation(nearestEnemy.transform.position - transform.position, Vector3.back);
        }

        rb.AddForce(transform.forward * missileAccelerationForce * Time.deltaTime, ForceMode.Acceleration);

        
        if (rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = rb.velocity.normalized * maxVelocity;
        }

//        Debug.Log("I am going at " + rb.velocity.magnitude);

    }
}
