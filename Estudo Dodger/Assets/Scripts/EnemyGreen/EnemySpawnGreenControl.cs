using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnGreenControl : MonoBehaviour {


    public GameObject enemyGreen;
    public float enemyGreenSpawnTimer = 6.0f;

    float maxX = 6.0f;
    float startY = 6.0f;
    float randonX;


    public bool canSpawEnemy = true;



    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnGreenTimer());

    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnEnemy()
    {


        randonX = Random.Range(-maxX, maxX);
        Instantiate(enemyGreen.gameObject, new Vector3(randonX, startY, 0), Quaternion.identity);


    }

    IEnumerator SpawnGreenTimer()
    {
        while (canSpawEnemy)
        {

            SpawnEnemy();
            yield return new WaitForSeconds(enemyGreenSpawnTimer);
        }

    }



}