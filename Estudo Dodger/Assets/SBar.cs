using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SBar : MonoBehaviour {


    public Scrollbar sb;
    public Text txt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ScrolB(){
        if (sb.value == 0)
        {
            txt.text = "ZERO000000000";
        }
    }
}
