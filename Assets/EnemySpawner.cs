using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject[] enemyPrefabs;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 2, 2);
	}

    private void SpawnEnemy()
    {
        int prefabIndex = Random.Range(0, enemyPrefabs.Length);

        Vector3 pos = new Vector3(Random.Range(-5f, 5f), 6, 0);

        GameObject enemy = Instantiate(enemyPrefabs[prefabIndex], pos, Quaternion.identity);
    }
}
