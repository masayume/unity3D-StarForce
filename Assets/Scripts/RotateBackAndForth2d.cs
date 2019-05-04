using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBackAndForth2d : MonoBehaviour
{

    public float rotation = 90;
    public float rotationTime = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("RotateForth");        
    }

    IEnumerator RotateForth()
    {
        float t = 0.0f;

        while (t < rotationTime * 0.5f)
        {
            transform.RotateAround(transform.position, transform.forward, Time.deltaTime / (rotationTime * 0.5f) * rotation);
            t += Time.deltaTime;
            yield return null;
        }

        StartCoroutine("RotateBack");

    }

    IEnumerator RotateBack()
    {
        float t = 0.0f;

        while (t < rotationTime * 0.5f)
        {
            transform.RotateAround(transform.position, transform.forward, -Time.deltaTime / (rotationTime * 0.5f) * rotation);
            t += Time.deltaTime;
            yield return null;
        }

        StartCoroutine("RotateForth");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
