using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnTrigger : MonoBehaviour
{
    public GameObject gib = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        if (gib != null)
        {
            Instantiate(gib, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);

    }


}
