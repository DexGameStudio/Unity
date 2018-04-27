using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SL : MonoBehaviour {

    public Slider slder;
    public Text txt;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AlterarTexto(){

        txt.text = slder.value.ToString();
    }
}
