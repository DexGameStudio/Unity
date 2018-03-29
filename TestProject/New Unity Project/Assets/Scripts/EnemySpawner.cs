using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemyToSpawn;
    public bool canSpawn = true;
    public float enemySpawnTime = 0.5f;
    public float maxAxis = 21.0f;
    public float startingY = 30.0f;
    float randomX = 0f;


	void Start () {
        StartCoroutine(SpawnEnemyTimer());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnEnemyTimer(){

        while (canSpawn)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(enemySpawnTime);
        }

    }

    void SpawnEnemy(){
        randomX = Random.Range(maxAxis, -maxAxis);

        Instantiate(enemyToSpawn, new Vector3(randomX, startingY, 0), Quaternion.identity);

    }

}
