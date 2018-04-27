using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyYellowController : MonoBehaviour {

    public float enemySpeedDown = 10f;

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
