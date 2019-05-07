using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnTrigger : MonoBehaviour
{
    public GameObject gib = null;
    public GameObject objectToDestroy = null;

    // Start is called before the first frame update
    void Start()
    {
        if (objectToDestroy == null)
        {
            objectToDestroy = gameObject;
        }
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        if (gib != null)
        {
            // Instantiate(gib, transform.position, Quaternion.identity);
            Instantiate(gib, transform.position, gib.transform.rotation);
        }

        if (transform.parent != null)
        {
            transform.parent.SendMessage("Dead", transform.position, SendMessageOptions.DontRequireReceiver);
        }
        Destroy(objectToDestroy);

    }


}
