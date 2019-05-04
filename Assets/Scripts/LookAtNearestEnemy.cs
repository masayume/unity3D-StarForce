using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtNearestEnemy : MonoBehaviour
{

    private Quaternion _lookRotation;
    private Vector3 _direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float rotationSpeed = 20.0f;
        float nearestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Enemies"))
        {
            // nearest one ?
            float distance = (transform.position - obj.transform.position).sqrMagnitude;
            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestEnemy = obj;
            }

//            float step = speed * Time.deltaTime;
//            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);

        }


        // nearest enemy now - rotates axis x, y instead on z
        if (nearestEnemy != null)
        {
            Vector3 look = nearestEnemy.transform.position - transform.position;
//            transform.rotation = Quaternion.LookRotation(look);
//            transform.rotation *= Quaternion.Euler(0, 0, 0);

            //find the vector pointing from our position to the target
            _direction = look.normalized;

            //create the rotation we need to be in to look at the target
            _lookRotation = Quaternion.LookRotation(_direction);

            //rotate us over time according to speed until we are in the required rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * rotationSpeed);
        }

    }
}
