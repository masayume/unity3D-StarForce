using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;


        void OnGUI()
    {
        if (gameOver)
        {
            GUILayout.Label("GAME OVER: Press Return to Restart !");
        }
    }

    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

}
