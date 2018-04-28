using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MorteUI : MonoBehaviour {


    public Image img;

    public void Morte(){
        img.fillAmount -= 0.25f;
    }

}
