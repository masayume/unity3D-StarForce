using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FodderAI : MonoBehaviour
{
    public float speed = 1.0f; // forward speed
    public float sinAmplitude = 1.0f;
    public float sinFrequency = 1.0f;
    private float horizontalOffset = 0.0f;
    private float time;
    Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        myTransform.position -= horizontalOffset * myTransform.right;

        myTransform.position += -myTransform.up * speed * Time.deltaTime;

        // adjust horizontal position by sine wave
        horizontalOffset = Mathf.Sin(time * sinFrequency * 2 * Mathf.PI) * sinAmplitude;

        myTransform.position += horizontalOffset * myTransform.right;


    }
}
