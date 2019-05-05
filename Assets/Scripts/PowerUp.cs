using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    void OnTriggerEnter()
    {
        GameObject.FindGameObjectWithTag("Player").SendMessage("PowerUp");
        Destroy(gameObject);
    }

}
