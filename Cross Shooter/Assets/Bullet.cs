using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Vector2 moveDirection;
    public float speed = 8 ;

    public float lifetime = 2.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Rigidbody2D>().velocity = moveDirection * speed;

        lifetime -= Time.deltaTime;

        if(lifetime <= 0){
            Destroy(this.gameObject);
        }
    }

   

}
