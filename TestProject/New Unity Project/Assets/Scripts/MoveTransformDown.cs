using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransformDown : MonoBehaviour {

    public float enemySpeed = 10f;


    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveToBotom();
	}

    void MoveToBotom(){
        transform.Translate(0, -enemySpeed*Time.deltaTime, 0);
    }

}
