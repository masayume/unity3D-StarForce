using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float verticalScrollSpeed = 1f;
    public float horizontalScrollMultiplier = 0.1f;

    private GameObject player;

    // will adjust m_back-starforce-01 y offset

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (player != null)
        {
            Vector2 newTextureOffset = GetComponent<Renderer>().material.mainTextureOffset;

            newTextureOffset.x = player.transform.position.x * horizontalScrollMultiplier;
            newTextureOffset.y += verticalScrollSpeed * Time.deltaTime;

            GetComponent<Renderer>().material.mainTextureOffset = newTextureOffset;
        }
        else
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }
}
