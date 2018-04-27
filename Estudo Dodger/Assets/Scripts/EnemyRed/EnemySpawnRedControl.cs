using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnRedControl : MonoBehaviour
{

    public GameObject enemyRed;
    public float enemyRedSpawnTimer = 20.0f;


    float maxX = 6.0f;
    float startY = 6.0f;
    float randonX;


    public bool canSpawEnemy = true;



    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnEnemyRed());

    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnEnemy()
    {


        randonX = Random.Range(-maxX, maxX);
        Instantiate(enemyRed.gameObject, new Vector3(randonX, startY, 0), Quaternion.identity);


    }

    IEnumerator SpawnEnemyRed()
    {
        while (canSpawEnemy)
        {

            SpawnEnemy();
            yield return new WaitForSeconds(enemyRedSpawnTimer);
        }

    }



}