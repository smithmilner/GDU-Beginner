using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public SpawnableEnemy[] enemyPrefabs;
    public float startDelay = 2f;
    public float delay = 0.3f;
    
    private float enemyPrefabWeightTotal;
    private void Start() {
        InvokeRepeating("SpawnEnemy", startDelay, delay);

        // Get sum of the enemy prefab weights.
        enemyPrefabWeightTotal = 0;
        for (int i = 0; i < enemyPrefabs.Length; i++) {
            enemyPrefabWeightTotal += enemyPrefabs[i].weight;
        }
    }

    public void SpawnEnemy () {
        GameObject enemy = Instantiate(getRandomEnemyPrefab(), getRandomXPosition(), transform.rotation);
        enemy.transform.parent = transform;
    }

    private GameObject getRandomEnemyPrefab() {
        GameObject enemy = enemyPrefabs[0].enemyPrefab;

        float total = 0;
        float randVal = Random.Range(0, enemyPrefabWeightTotal);

        for (int index = 0; index < enemyPrefabs.Length; index++) {
            total += enemyPrefabs[index].weight;
            if (total >= randVal) {
                enemy = enemyPrefabs[index].enemyPrefab;
                break;
            }
        }

        return enemy;
    }

    static public Vector3 getRandomXPosition() {
        return new Vector3(Random.Range(-9f, 9f), 10);
    }

    [System.Serializable]
    public struct SpawnableEnemy {
        public GameObject enemyPrefab;
        [Range(0f, 1f)]
        public float weight;
    }
}

