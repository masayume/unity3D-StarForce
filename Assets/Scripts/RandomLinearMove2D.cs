using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLinearMove2D : MonoBehaviour
{

    public float maxDistance = 1.0f;
    public float moveTime = 1.0f;
    public float waitTime = 1.0f;
    public bool remainNearInitialPosition = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("RandomMove");
    }

    IEnumerator RandomMove()
    {
        float t = 0.0f;
        float currentMoveTime = moveTime;
        Vector3 initialPosition = transform.position;
        Vector3 moveVector = Random.insideUnitCircle * maxDistance;
        Vector3 endPosition = initialPosition + moveVector;

        if (currentMoveTime < 0.0f)
        {
            currentMoveTime = float.Epsilon;

        }

        while (t < currentMoveTime)
        {
            transform.position = Vector3.Lerp(initialPosition, endPosition, t / currentMoveTime);
            t += Time.deltaTime;
            yield return null;

        }

        yield return new WaitForSeconds(waitTime);

        StartCoroutine("RandomMove");
    }

    // Update is called once per frame

}
