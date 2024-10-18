using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float yPos = 5f;
    public float minXPos = -8f;
    public float maxXPos = 8f;

    public float spawnCooldown = 1f;
    float spawnTimer = 0f;

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnCooldown)
        {
            spawnTimer = 0f;
            float xPos = Random.Range(minXPos, maxXPos);
            Instantiate(enemyPrefab, new Vector3(xPos, yPos, 0), Quaternion.identity);
        }
    }
}
