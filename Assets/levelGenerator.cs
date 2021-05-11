using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;

    public int numberOfPlatforms = 200 ;

    public float minY;
    public float maxY;
    public float minX;
    public float maxX;
    void Start()
    {
        Vector2 spawnTransform = new Vector2();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnTransform.y += Random.Range(minY, maxY);
            spawnTransform.x = Random.Range(minX, maxX);
            Instantiate(platformPrefab, spawnTransform, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
