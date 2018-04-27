using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toogle : MonoBehaviour {

    public Text txt;
    public Toggle tg;


	// Use this for initialization
	void Start () {
        tg = GetComponent<Toggle>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Toggle(){
        txt.text = tg.GetComponentInChildren<Text>().text;
    }

}
