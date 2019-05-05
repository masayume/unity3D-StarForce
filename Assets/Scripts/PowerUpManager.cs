using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Shoot[] weapons;
    private int powerLevel = -1;

    // Start is called before the first frame update
    void PowerUp()
    {
        powerLevel++;
        if (powerLevel < weapons.Length)
        {
            weapons[powerLevel].enabled = true;
        }
    }


}
