using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPurpleController : MonoBehaviour {

    public float enemySpeedDown = 5.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveToBottom();
    }

    void MoveToBottom()
    {
        transform.Translate(0, -enemySpeedDown * Time.deltaTime, 0);
    }
}
