using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPurpleControl : MonoBehaviour {



    public GameObject enemyPurple;
    public float enemyPurpleSpawnTimer = 12.0f;

    float maxX = 6.0f;
    float startY = 6.0f;
    float randonX;

    public bool canSpawEnemy = true;



    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnPurpleRed());

    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnEnemy()
    {


        randonX = Random.Range(-maxX, maxX);
        Instantiate(enemyPurple.gameObject, new Vector3(randonX, startY, 0), Quaternion.identity);


    }

    IEnumerator SpawnPurpleRed()
    {
        while (canSpawEnemy)
        {

            SpawnEnemy();
            yield return new WaitForSeconds(enemyPurpleSpawnTimer);
        }

    }



}