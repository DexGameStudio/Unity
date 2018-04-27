using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollRawImage : MonoBehaviour {


    public RawImage heartRaw;
 

	// Use this for initialization
	void Start () {
        


	}
	
	// Update is called once per frame
	void Update () {


        //Utilizando Scrolling com RawImage
        Rect temp = new Rect(heartRaw.uvRect);
        temp.x += 0.1f * Time.deltaTime;
        heartRaw.uvRect = temp;
		

	}
}
