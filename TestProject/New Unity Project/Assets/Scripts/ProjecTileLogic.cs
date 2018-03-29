using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecTileLogic : MonoBehaviour {

    public float projecTileSpeed = 40f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveProjecTileToUp();		
	}
    void MoveProjecTileToUp(){
        transform.Translate(0, projecTileSpeed*Time.deltaTime, 0);
    }
}
