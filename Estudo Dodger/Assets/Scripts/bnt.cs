using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bnt : MonoBehaviour {

    public GameObject green;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void EventoBTN(){
        Instantiate(green, new Vector2(0, 0), Quaternion.identity);
    }


}
