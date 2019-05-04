using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnInvisible : MonoBehaviour
{
    public GameObject destroyTarget = null;

    void OnBecameInvisible()
    {
        if (destroyTarget == null)
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(destroyTarget);
        }


    }

    

}
