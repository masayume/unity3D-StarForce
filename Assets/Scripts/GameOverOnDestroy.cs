using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnDestroy : MonoBehaviour
{
    void OnDestroy()
    {

        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");

        if (gameManagerObject != null) {
            GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
            gameManager.gameOver = true;
        }
    }

}
