using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;    
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f) * speed * Time.deltaTime;
    }
}
