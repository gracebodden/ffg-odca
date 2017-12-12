using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacle : MonoBehaviour {

    public float minSpread = 5;
    public float maxSpread = 15;
    public float iteration = 1;

    public Transform playerTransform;
    public Transform obstaclePrefab;

    float ySpread;
    float lastYPos;

    void Start()
    {
        lastYPos = Mathf.NegativeInfinity;
        ySpread = Random.Range(minSpread, maxSpread);
    }

    void Update()
    {
        if (iteration%100 == 0)
        {
            float bottomXPos = Random.Range(0, 7);
            float topXPos = Random.Range(0, 7);
            float bottomYPos = Random.Range(-7, -2);
            float topYPos = Random.Range(2, 8);
            //xPos = (xPos - 1) * 1.5f;
            Instantiate(obstaclePrefab, new Vector3(bottomXPos + 16, bottomYPos, 0), Quaternion.identity);
            Instantiate(obstaclePrefab, new Vector3(topXPos + 16, topYPos, 0), Quaternion.identity);

            lastYPos = playerTransform.position.y;
            ySpread = Random.Range(minSpread, maxSpread);
        }
        iteration++;
    }
}
