using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {

    public Text txtVida;
    public Image imglifebarLife;

    int valorAtual = 100;
    int dano = 5;
    public int energia = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void VidaBarMenos(){
        if (valorAtual > 0)
        {
            valorAtual -= dano;
            imglifebarLife.fillAmount = (float)valorAtual / 100;
            string temp = valorAtual.ToString();
            txtVida.text = temp;

        }
    }

    public void Potion(){
        if (valorAtual < 100)
        {
            valorAtual += energia;
            imglifebarLife.fillAmount = (float)valorAtual / 100;
            string temp = valorAtual.ToString();
            txtVida.text = temp;

        }
    }


}
