using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnYellowControl : MonoBehaviour
{

   
    public GameObject enemyYellow;
    public float enemyYellowSpawnTimer = 3.0f;

    float maxX = 6.0f;
    float startY = 6.0f;
    float randonX;


    public bool canSpawEnemy = true;



    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnYellowTimer());

    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnEnemy()
    {


        randonX = Random.Range(-maxX, maxX);
        Instantiate(enemyYellow.gameObject, new Vector3(randonX, startY, 0), Quaternion.identity);


    }

    IEnumerator SpawnYellowTimer()
    {
        while (canSpawEnemy)
        {

            SpawnEnemy();
            yield return new WaitForSeconds(enemyYellowSpawnTimer);
        }

    }



}