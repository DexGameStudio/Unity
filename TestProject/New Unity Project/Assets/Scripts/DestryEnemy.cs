using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D transformcollision)
    {
        if (transformcollision.gameObject.tag == "Projectille")
        {

            Destroy(transformcollision.gameObject);

        }

    }
}
